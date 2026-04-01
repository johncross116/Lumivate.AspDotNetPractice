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

    public class TurtleService : ITurtleService
    {
        private static List<Turtle> _turtles = new List<Turtle>
        {
            new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m, Description = "A friendly and curious turtle.", IsAvailable = true },
            new Turtle { Id = 2, Name = "Tank", Species = "Box Turtle", Price = 49.99m, Description = "A sturdy and calm companion.", IsAvailable = true },
            new Turtle { Id = 3, Name = "Speedy", Species = "Painted Turtle", Price = 24.99m, Description = "Surprisingly quick for a turtle!", IsAvailable = true }
        };

        public List<Turtle> GetAllTurtles()
        {
            return _turtles;
        }

        public Turtle? GetTurtleById(int id)
        {
            return _turtles.FirstOrDefault(t => t.Id == id);
        }

        public void AddTurtle(Turtle turtle)
        {
            turtle.Id = _turtles.Any() ? _turtles.Max(t => t.Id) + 1 : 1;
            _turtles.Add(turtle);
        }

        public void UpdateTurtle(Turtle turtle)
        {
            var existing = _turtles.FirstOrDefault(t => t.Id == turtle.Id);
            if (existing != null)
            {
                existing.Name = turtle.Name;
                existing.Species = turtle.Species;
                existing.Description = turtle.Description;
                existing.Price = turtle.Price;
                existing.IsAvailable = turtle.IsAvailable;
            }
        }

        public void DeleteTurtle(int id)
        {
            var turtle = _turtles.FirstOrDefault(t => t.Id == id);
            if (turtle != null)
            {
                _turtles.Remove(turtle);
            }
        }
    }
}
