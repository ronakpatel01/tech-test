using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Tests1
{
    public static class MockedOrders
    {
        public static Order CreateNewOrder1()
        {
            return new Order()
            {
                OrderId = 1,
                Amount = 5d,
                VAT = 0
            };
        }
    }
}
