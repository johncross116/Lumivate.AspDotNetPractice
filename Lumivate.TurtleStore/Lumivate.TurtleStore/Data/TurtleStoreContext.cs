// TODO-checkpoint-3: Add the following using statements:
//   using Lumivate.TurtleStore.Models;
//   using Microsoft.EntityFrameworkCore;

namespace Lumivate.TurtleStore.Data
{
	// TODO-checkpoint-3: Create the TurtleStoreContext class
	// This class should inherit from DbContext, ie...
	//      public class TurtleStoreContext : DbContext { }
	//
	// 1. Add a constructor that accepts DbContextOptions<TurtleStoreContext> and passes it to the base class, ie...
	//      public TurtleStoreContext(DbContextOptions<TurtleStoreContext> options) : base(options) { }
	//
	// 2. Add a DbSet property for your Turtles, Orders, and OrderItems:
	//      public DbSet<Turtle> Turtles { get; set; }
	//      public DbSet<Order> Orders { get; set; }
	//      public DbSet<OrderItem> OrderItems { get; set; }
	//
	// 3. Override OnModelCreating to seed sample data. Uncomment the following...
	//      protected override void OnModelCreating(ModelBuilder modelBuilder)
	//      {
	//          modelBuilder.Entity<Turtle>().HasData(
	//              new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m, Description = "A friendly and curious turtle.", IsAvailable = true },
	//              new Turtle { Id = 2, Name = "Tank", Species = "Box Turtle", Price = 49.99m, Description = "A sturdy and calm companion.", IsAvailable = true },
	//              new Turtle { Id = 3, Name = "Speedy", Species = "Painted Turtle", Price = 24.99m, Description = "Surprisingly quick for a turtle!", IsAvailable = true }
	//          );
	//      }
}
