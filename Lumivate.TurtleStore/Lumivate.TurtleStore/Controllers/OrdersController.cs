using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    public class OrdersController : Controller
    {
        // TODO (Module 5): Create the Checkout action (GET)
        // Display the checkout form with cart items and total
        // If the cart is empty, redirect to the Cart Index

        // TODO (Module 5): Create the PlaceOrder action (POST)
        // Accept the CheckoutViewModel, validate it, place the order,
        // clear the cart, and redirect to the Confirmation page

        // TODO (Module 5): Create the Confirmation action (GET)
        // Accept an order id, look up the order, and display confirmation
        // If the order is not found, return NotFound()
    }
}
