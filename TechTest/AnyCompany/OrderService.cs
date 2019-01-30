namespace AnyCompany
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (order.Amount == 0)
                return false;

            order.VAT = VatCalculation.VatRateForCustomer(customer);

            orderRepository.Save(order);

            return true;
        }
    }
}
