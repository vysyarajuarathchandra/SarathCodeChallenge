using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Services
{
    public interface IOrderService
    {
    
        
            void PlaceOrder(Order order);
            List<Order> GetOrders();
           Order GetOrdersByProductId(int productId);
 
    }
}
