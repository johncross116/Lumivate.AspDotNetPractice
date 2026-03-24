using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;

        public OrdersController(IOrderService orderService, ICartService cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        // GET: /Orders/Checkout
        public IActionResult Checkout()
        {
            var cartItems = _cartService.GetCartItems();
            if (!cartItems.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            var viewModel = new CheckoutViewModel
            {
                CartItems = cartItems,
                TotalAmount = _cartService.GetCartTotal()
            };
            return View(viewModel);
        }

        // POST: /Orders/PlaceOrder
        [HttpPost]
        public IActionResult PlaceOrder(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.CartItems = _cartService.GetCartItems();
                model.TotalAmount = _cartService.GetCartTotal();
                return View("Checkout", model);
            }

            var cartItems = _cartService.GetCartItems();
            var order = _orderService.PlaceOrder(model.CustomerName, model.CustomerEmail, cartItems);
            _cartService.ClearCart();

            return RedirectToAction("Confirmation", new { id = order.Id });
        }

        // GET: /Orders/Confirmation/1
        public IActionResult Confirmation(int id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }
}
