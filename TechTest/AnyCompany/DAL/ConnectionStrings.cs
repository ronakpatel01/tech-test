using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    //Ideally this could be in web.config / app.config or a connection strings file.
    public class ConnectionStrings
    {
        public const string CustomersConnectionString = @"Data Source=(local);Database=Customers;User Id=admin;Password=password;";

        public const string OrdersConnectionString = @"Data Source=(local);Database=Orders;User Id=admin;Password=password;";
    }
}
