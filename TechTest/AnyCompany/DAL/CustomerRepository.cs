  using System;
using System.Data.SqlClient;

namespace AnyCompany
{
    public static class CustomerRepository
    {
        public static Customer Load(int customerId)
        {
            Customer customer = new Customer();

            using (SqlConnection connection = new SqlConnection(ConnectionStrings.CustomersConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerId = " + customerId,
                    connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        customer.Name = reader["Name"].ToString();
                        customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                        customer.Country = reader["Country"].ToString();
                    }
                }
            }
            return customer;
        }
    }
}
