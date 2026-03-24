using Lumivate.TurtleStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        // GET: /Cart
        public IActionResult Index()
        {
            var items = _cartService.GetCartItems();
            ViewBag.Total = _cartService.GetCartTotal();
            return View(items);
        }

        // POST: /Cart/Add/5
        [HttpPost]
        public IActionResult Add(int id)
        {
            _cartService.AddToCart(id);
            return RedirectToAction("Index");
        }

        // POST: /Cart/Remove/5
        [HttpPost]
        public IActionResult Remove(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
