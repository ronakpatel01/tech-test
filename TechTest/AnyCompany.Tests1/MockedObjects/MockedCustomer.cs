using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Tests1
{
    public static class MockedCustomer
    {
        public static Customer Customer1()
        {
            return new Customer()
            {
                Country = "UK",
                DateOfBirth = new DateTime(1980, 2, 3),
                Name = "John Smith"
            };
        }

        public static Customer Customer2()
        {
            return new Customer()
            {
                Country = "France",
                DateOfBirth = new DateTime(1985, 8, 4),
                Name = "Joe Bloggs"
            };
        }
    }
}
