using Lumivate.TurtleStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    public class CartController : Controller
    {
        private static readonly List<CartItem> _cartItems = new List<CartItem>();

        // GET: /Cart
        public IActionResult Index()
        {
            ViewBag.Total = _cartItems.Sum(c => (c.Turtle?.Price ?? 0) * c.Quantity);
            return View(_cartItems);
        }

        // POST: /Cart/Add/5
        [HttpPost]
        public IActionResult Add(int id)
        {
            var existingItem = _cartItems.FirstOrDefault(c => c.TurtleId == id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                var turtle = TurtlesController.GetTurtleById(id);
                if (turtle != null)
                {
                    _cartItems.Add(new CartItem
                    {
                        Id = _cartItems.Count + 1,
                        TurtleId = id,
                        Turtle = turtle,
                        Quantity = 1
                    });
                }
            }
            return RedirectToAction("Index");
        }

        // POST: /Cart/Remove/5
        [HttpPost]
        public IActionResult Remove(int id)
        {
            var item = _cartItems.FirstOrDefault(c => c.TurtleId == id);
            if (item != null)
            {
                _cartItems.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}
