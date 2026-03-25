using Lumivate.TurtleStore.Models;

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
}
