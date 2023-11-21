using SarathCodeChallenge.Database;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Services
{
    public class OrderService : IOrderService
    {
        private readonly MyContext context;
        public OrderService(MyContext context)
        {
            context = context;
        }
        public List<Order> GetOrders()
        {
            try
            {
                return context.Orders.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void PlaceOrder(Order order)
        {
            try
            {
                context.Orders.Remove(order);

            }
            catch (Exception)
            {

                throw;
            }
        }

        Order IOrderService.GetOrdersByProductId(int productId)
        {
            try
            {
                return context.Orders.SingleOrDefault(o => o.ProductId == productId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
