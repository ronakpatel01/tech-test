using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public class VatCalculation
    {
        public static double VatRateForCustomer(Customer customer)
        {
            if (customer.Country == "UK")
                return 0.2d;
            else
                return 0;
        }
    }
}
