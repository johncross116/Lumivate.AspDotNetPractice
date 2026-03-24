using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public class OrderService : IOrderService
    {
        private static readonly List<Order> _orders = new List<Order>();

        public Order PlaceOrder(string customerName, string customerEmail, List<CartItem> items)
        {
            var order = new Order
            {
                Id = _orders.Count + 1,
                OrderDate = DateTime.Now,
                CustomerName = customerName,
                CustomerEmail = customerEmail,
                TotalAmount = items.Sum(i => (i.Turtle?.Price ?? 0) * i.Quantity),
                Items = items.Select(i => new OrderItem
                {
                    TurtleId = i.TurtleId,
                    TurtleName = i.Turtle?.Name ?? "Unknown",
                    Price = i.Turtle?.Price ?? 0,
                    Quantity = i.Quantity
                }).ToList()
            };

            _orders.Add(order);
            return order;
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        public Order? GetOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }
    }
}
