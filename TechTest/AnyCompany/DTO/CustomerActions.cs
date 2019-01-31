using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public class CustomerActions
    {
        private readonly OrderActions orderActions = new OrderActions();

        public Customer GetCustomerFromId(int customerId)
        {
            return CustomerRepository.Load(customerId);
        }

        public Customer[] GetAllCustomers()
        {
            Customer[] customers = CustomerRepository.LoadAllCustomers();
            foreach (Customer customer in customers)
            {
                customer.Orders = orderActions.GetOrdersForCustomer(customer.CustomerId);
            }

            return customers;
        }
    }
}
