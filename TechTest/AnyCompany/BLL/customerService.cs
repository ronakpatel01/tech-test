using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.BLL
{
    public class CustomerService
    {
        CustomerActions customerActions = new CustomerActions();

        public Customer[] GetAllCustomers()
        {
            return customerActions.GetAllCustomers();
        }
    }
}
