using Microsoft.EntityFrameworkCore;

namespace Lumivate.TurtleStore.Data
{
    // TODO (Module 4): Set up the TurtleStoreContext
    // 1. Make this class inherit from DbContext
    // 2. Add a constructor that accepts DbContextOptions<TurtleStoreContext> and passes it to base
    // 3. Add DbSet properties for Turtle, Order, and OrderItem
    //    Example: public DbSet<Models.Turtle> Turtles { get; set; }
    // 4. Override OnModelCreating to add seed data for turtles
    //    Example:
    //      protected override void OnModelCreating(ModelBuilder modelBuilder)
    //      {
    //          modelBuilder.Entity<Models.Turtle>().HasData(
    //              new Models.Turtle { Id = 1, Name = "Shelly", ... }
    //          );
    //      }
    public class TurtleStoreContext
    {
    }
}
