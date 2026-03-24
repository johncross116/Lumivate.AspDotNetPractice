using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public class CartService : ICartService
    {
        private static readonly List<CartItem> _cartItems = new List<CartItem>();
        private readonly ITurtleService _turtleService;

        public CartService(ITurtleService turtleService)
        {
            _turtleService = turtleService;
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        public void AddToCart(int turtleId)
        {
            var existingItem = _cartItems.FirstOrDefault(c => c.TurtleId == turtleId);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                var turtle = _turtleService.GetTurtleById(turtleId);
                if (turtle != null)
                {
                    _cartItems.Add(new CartItem
                    {
                        Id = _cartItems.Count + 1,
                        TurtleId = turtleId,
                        Turtle = turtle,
                        Quantity = 1
                    });
                }
            }
        }

        public void RemoveFromCart(int turtleId)
        {
            var item = _cartItems.FirstOrDefault(c => c.TurtleId == turtleId);
            if (item != null)
            {
                _cartItems.Remove(item);
            }
        }

        public void ClearCart()
        {
            _cartItems.Clear();
        }

        public decimal GetCartTotal()
        {
            return _cartItems.Sum(c => (c.Turtle?.Price ?? 0) * c.Quantity);
        }
    }
}
