using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public interface ICartService
    {
        List<CartItem> GetCartItems();
        void AddToCart(int turtleId);
        void RemoveFromCart(int turtleId);
        void ClearCart();
        decimal GetCartTotal();
    }
}
