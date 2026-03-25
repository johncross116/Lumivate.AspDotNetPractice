// TODO-checkpoint-3: Add the following using statements:
//   using Lumivate.TurtleStore.Models;
//   using Microsoft.EntityFrameworkCore;

namespace Lumivate.TurtleStore.Data
{
    // TODO-checkpoint-3: Create the TurtleStoreContext class
    // This class should inherit from DbContext.
    //
    // 1. Add a constructor that accepts DbContextOptions<TurtleStoreContext> and passes it to the base class:
    //      public TurtleStoreContext(DbContextOptions<TurtleStoreContext> options) : base(options) { }
    //
    // 2. Add a DbSet property for Turtles:
    //      public DbSet<Turtle> Turtles { get; set; }
    //
    // 3. (Optional) Override OnModelCreating to seed sample data:
    //      protected override void OnModelCreating(ModelBuilder modelBuilder)
    //      {
    //          modelBuilder.Entity<Turtle>().HasData(
    //              new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Age = 3, Price = 29.99m, Description = "A friendly and curious turtle." },
    //              new Turtle { Id = 2, Name = "Tank", Species = "Box Turtle", Age = 5, Price = 49.99m, Description = "A sturdy and calm companion." },
    //              new Turtle { Id = 3, Name = "Speedy", Species = "Painted Turtle", Age = 2, Price = 24.99m, Description = "Surprisingly quick for a turtle!" }
    //          );
    //      }
}
