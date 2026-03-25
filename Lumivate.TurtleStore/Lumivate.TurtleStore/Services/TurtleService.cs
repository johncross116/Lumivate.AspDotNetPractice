using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    // TODO-checkpoint-4: Create the TurtleService class that implements ITurtleService
    //
    // This service will contain the business logic for turtle operations.
    //
    // For now, use a private static List<Turtle> as an in-memory data store.
    // Initialize it with a few sample turtles in the constructor or as a field initializer.
    //
    // Implement all methods from ITurtleService:
    //   - GetAllTurtles(): return the full list
    //   - GetTurtleById(int id): return a single turtle using LINQ's FirstOrDefault
    //   - AddTurtle(Turtle turtle): assign a new Id and add to the list
    //   - UpdateTurtle(Turtle turtle): find existing turtle by Id and update its properties
    //   - DeleteTurtle(int id): remove the turtle with the matching Id

    // TODO-checkpoint-4: After creating this class, register it in Program.cs:
    //   builder.Services.AddScoped<ITurtleService, TurtleService>();
}
