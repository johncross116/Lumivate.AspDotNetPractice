using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    // TODO-checkpoint-2: Create the CartController class
    // This controller should inherit from Controller.
    //
    // For now, use a private static List<CartItem> to store cart items in memory.
    // The cart does not need to persist between app restarts.
    //
    // Add the following actions:
    //   - Index() [HttpGet]: Display the current cart contents
    //     Return View() with the list of cart items
    //
    //   - Add(int turtleId) [HttpPost]: Add a turtle to the cart
    //     If the turtle is already in the cart, increase the quantity
    //     Otherwise, add a new CartItem with Quantity = 1
    //     Redirect to the Turtles Index page
    //
    //   - Remove(int turtleId) [HttpPost]: Remove a turtle from the cart
    //     Remove the CartItem with the matching TurtleId
    //     Redirect to the Cart Index page

    // TODO-checkpoint-4: Refactor this controller to accept ICartService via constructor injection
    //   - Remove the static list
    //   - Call _cartService methods instead

    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _cartService.GetCartItems();
            return View(items);
        }

        [HttpPost]
        public IActionResult Add(int turtleId)
        {
            _cartService.AddToCart(turtleId);
            return RedirectToAction("Index", "Turtles");
        }

        [HttpPost]
        public IActionResult Remove(int turtleId)
        {
            _cartService.RemoveFromCart(turtleId);
            return RedirectToAction(nameof(Index));
        }
    }
}
