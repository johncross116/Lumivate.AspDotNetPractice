using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
	// TODO-checkpoint-4: Create the ICartService interface
	// Define the following method signatures. Make sure these signatures match the methods you will implement in CartService.cs.
	//   - List<CartItem> GetCartItems()
	//   - void AddToCart(int turtleId)
	//   - void RemoveFromCart(int turtleId)
	//   - decimal GetCartTotal()
	//   - void ClearCart()

    public interface ICartService
    {
        List<CartItem> GetCartItems();
        void AddToCart(int turtleId);
        void RemoveFromCart(int turtleId);
        decimal GetCartTotal();
        void ClearCart();
    }
}
