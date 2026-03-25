using Lumivate.TurtleStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
    // TODO-checkpoint-2: Create the TurtlesController class
    // This controller should inherit from Controller.
    // Add an Index() action that:
    //   1. Creates a list of Turtle objects (hardcoded for now)
    //   2. Wraps them in a TurtleViewModel
    //   3. Returns View(viewModel)
    //
    // Example turtles to add:
    //   - "Shelly", Red-Eared Slider, Age 3, $29.99
    //   - "Tank", Box Turtle, Age 5, $49.99
    //   - "Speedy", Painted Turtle, Age 2, $24.99

    // TODO-checkpoint-3: Add a Details(int id) action
    //   - This will later use EF Core to fetch a single turtle by id
    //   - For now, return View() with a single Turtle object

    // TODO-checkpoint-3: Add Create() GET and POST actions
    //   - GET: return an empty form view
    //   - POST: accept a Turtle model, later save to database, redirect to Index

    // TODO-checkpoint-4: Refactor this controller to accept ITurtleService via constructor injection
    //   - Remove hardcoded turtle lists
    //   - Call _turtleService methods instead
}
