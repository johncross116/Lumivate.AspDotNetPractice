using Lumivate.TurtleStore.Data;
using Lumivate.TurtleStore.Models;
using Microsoft.EntityFrameworkCore;

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
        private readonly TurtleStoreContext _context;

        public TurtleService(TurtleStoreContext context)
        {
            _context = context;
        }

        public List<Turtle> GetAllTurtles()
        {
            return _context.Turtles.ToList();
        }

        public Turtle? GetTurtleById(int id)
        {
            return _context.Turtles.FirstOrDefault(t => t.Id == id);
        }

        public void AddTurtle(Turtle turtle)
        {
            _context.Turtles.Add(turtle);
            _context.SaveChanges();
        }

        public void UpdateTurtle(Turtle turtle)
        {
            var existing = _context.Turtles.FirstOrDefault(t => t.Id == turtle.Id);
            if (existing != null)
            {
                existing.Name = turtle.Name;
                existing.Species = turtle.Species;
                existing.Description = turtle.Description;
                existing.Price = turtle.Price;
                existing.IsAvailable = turtle.IsAvailable;
                _context.SaveChanges();
            }
        }

        public void DeleteTurtle(int id)
        {
            var turtle = _context.Turtles.FirstOrDefault(t => t.Id == id);
            if (turtle != null)
            {
                _context.Turtles.Remove(turtle);
                _context.SaveChanges();
            }
        }
    }
}
