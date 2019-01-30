namespace AnyCompany
{
    public class OrderService
   {
        private readonly CustomerActions customerActions = new CustomerActions();
        private readonly OrderActions orderActions = new OrderActions();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = customerActions.GetCustomerFromId(customerId);
            bool updated = UpdateOrder(order, customer);

            if (updated)
                orderActions.SaveOrder(order);

            return updated;
        }

        public bool UpdateOrder(Order order, Customer customer)
        {
            if (order.Amount == 0)
                return false;

            order.VAT = VatCalculation.VatRateForCustomer(customer);

            return true;
        }
    }
}
