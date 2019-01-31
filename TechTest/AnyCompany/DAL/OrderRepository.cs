using System.Collections.Generic;
using System.Data.SqlClient;

namespace AnyCompany
{
    internal class OrderRepository
    {
        public void Save(Order order, int customerId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.OrdersConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (@OrderId, @Amount, @VAT)", connection))
                {
                    command.Parameters.AddWithValue("@OrderId", order.OrderId);
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@Amount", order.Amount);
                    command.Parameters.AddWithValue("@VAT", order.VAT);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Order[] LoadOrdersForCustomer(int customerId)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection connection = new SqlConnection(ConnectionStrings.OrdersConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE CustomerId = " + customerId,
                    connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order();

                        order.OrderId = reader.GetInt32(reader.GetOrdinal("OrderId"));
                        order.Amount = reader.GetDouble(reader.GetOrdinal("Amount"));
                        order.VAT = reader.GetDouble(reader.GetOrdinal("VAT"));

                        orders.Add(order);
                    }
                }
            }
            return orders.ToArray();
        }
    }
}
