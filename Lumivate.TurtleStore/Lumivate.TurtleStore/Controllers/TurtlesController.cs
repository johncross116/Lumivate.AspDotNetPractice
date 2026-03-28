using Lumivate.TurtleStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TurtleStore.Controllers
{
	// TODO-checkpoint-1: Create the TurtlesController class
	// This controller should inherit from Controller.
	// Add an Index() action that:
	//   1. Creates a static list of Turtle objects (hardcoded for now)
	//   2. Returns View(turtles) passing the list directly
	//
	// Example turtles to add (feel free to add your own though!)
	//   - "Shelly", Red-Eared Slider, $29.99, "A friendly and curious turtle."
	//   - "Tank", Box Turtle, $49.99, "A sturdy and calm companion."
	//   - "Speedy", Painted Turtle, $24.99, "Surprisingly quick for a turtle!"
	//
	// Tip: Take a look at the HomeController and copy the structure of the Index action to get started.
	//      The main difference will be adding a list of Turtles and passing it to the view, for example:
	//      List<Turtle> turtles = new List<Turtle> { ... };
	//      return View(turtles);

	// TODO-checkpoint-2: Refactor your Index action to use a TurtleViewModel
	//   - Create a TurtleViewModel and set its Turtles property to your list
	//   - Return View(viewModel) instead of View(turtles)

	// TODO-checkpoint-3: Add a Details(int id) action
	//   - Use the DbContext to fetch a single turtle by id
	//   - Return View(turtle)

	// TODO-checkpoint-3: Add Create() GET and POST actions
	//   - GET: return an empty form view
	//   - POST: accept a Turtle model, save to database, redirect to Index

	// TODO-checkpoint-4: Refactor this controller to accept ITurtleService via constructor injection
	//   - Remove direct database access
	//   - Call _turtleService methods instead
}
