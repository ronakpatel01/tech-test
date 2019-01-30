using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyCompany.Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrderUpdateUK()
        {
            Order order = MockedOrders.Order1();
            Customer customer = MockedCustomer.Customer1();

            OrderService orderService = new OrderService();

            orderService.UpdateOrder(order, customer);
            Assert.AreEqual(0.2d, order.VAT);
        }

        [TestMethod]
        public void TestOrderUpdateFrance()
        {
            Order order = MockedOrders.Order1();
            Customer customer = MockedCustomer.Customer2();

            OrderService orderService = new OrderService();

            orderService.UpdateOrder(order, customer);
            Assert.AreEqual(0, order.VAT);
        }
    }
}
