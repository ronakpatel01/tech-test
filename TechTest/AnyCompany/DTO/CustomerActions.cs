using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public class CustomerActions
    {
        public Customer GetCustomerFromId(int customerId)
        {
            return CustomerRepository.Load(customerId);
        }
    }
}
