using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public class OrderActions
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public void SaveOrder(Order order, int customerId)
        {
            orderRepository.Save(order, customerId);
            
        }



    }
}
