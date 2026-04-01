using Lumivate.TurtleStore.Data;
using Lumivate.TurtleStore.Models;
using Microsoft.EntityFrameworkCore;

namespace Lumivate.TurtleStore.Services
{
    // TODO-checkpoint-4: Create the OrderService class that implements IOrderService
    //
    // This service manages customer orders.
    // Use a private static List<Order> as an in-memory order store.
    //
    // Implement all methods from IOrderService:
    //   - PlaceOrder(string customerName, List<CartItem> items):
    //     Create a new Order with a generated Id, the customer name, current date,
    //     and convert CartItems to OrderItems. Calculate the total.
    //   - GetOrderById(int id): return the order with the matching Id
    //   - GetAllOrders(): return all orders

    // TODO-checkpoint-4: After creating this class, register it in Program.cs:
    //   builder.Services.AddScoped<IOrderService, OrderService>();

    public class OrderService : IOrderService
    {
        private readonly TurtleStoreContext _context;

        public OrderService(TurtleStoreContext context)
        {
            _context = context;
        }

        public Order PlaceOrder(string customerName, List<CartItem> items)
        {
            var order = new Order
            {
                CustomerName = customerName,
                OrderDate = DateTime.Now,
                Items = items.Select(ci => new OrderItem
                {
                    TurtleId = ci.TurtleId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.Turtle.Price
                }).ToList(),
                Total = items.Sum(ci => ci.Turtle.Price * ci.Quantity)
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public Order? GetOrderById(int id)
        {
            return _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Turtle)
                .FirstOrDefault(o => o.Id == id);
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Turtle)
                .ToList();
        }
    }
}
