using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public interface IOrderService
    {
        Order PlaceOrder(string customerName, string customerEmail, List<CartItem> items);
        List<Order> GetAllOrders();
        Order? GetOrderById(int id);
    }
}
