// TODO-checkpoint-5: Create unit tests for TurtleService using xUnit
//
// 1. Add the following using statements:
//    using Lumivate.TurtleStore.Models;
//    using Lumivate.TurtleStore.Services;
//    using Xunit;
//
// 2. Create a test class called TurtleServiceTests
//
// 3. Write the following test methods using the [Fact] attribute:
//
//    [Fact]
//    public void GetAllTurtles_ReturnsAllTurtles()
//    {
//        // Arrange
//        var service = new TurtleService();
//
//        // Act
//        var result = service.GetAllTurtles();
//
//        // Assert
//        Assert.NotNull(result);
//        Assert.True(result.Count > 0);
//    }
//
//    [Fact]
//    public void GetTurtleById_WithValidId_ReturnsTurtle()
//    {
//        // Arrange
//        var service = new TurtleService();
//
//        // Act
//        var result = service.GetTurtleById(1);
//
//        // Assert
//        Assert.NotNull(result);
//        Assert.Equal(1, result.Id);
//    }
//
//    [Fact]
//    public void GetTurtleById_WithInvalidId_ReturnsNull()
//    {
//        // Arrange
//        var service = new TurtleService();
//
//        // Act
//        var result = service.GetTurtleById(999);
//
//        // Assert
//        Assert.Null(result);
//    }
//
//    [Fact]
//    public void AddTurtle_IncreasesCount()
//    {
//        // Arrange
//        var service = new TurtleService();
//        var initialCount = service.GetAllTurtles().Count;
//        var newTurtle = new Turtle
//        {
//            Name = "Test Turtle",
//            Species = "Test Species",
//            Price = 9.99m,
//            IsAvailable = true
//        };
//
//        // Act
//        service.AddTurtle(newTurtle);
//
//        // Assert
//        Assert.Equal(initialCount + 1, service.GetAllTurtles().Count);
//    }
//
//    [Fact]
//    public void DeleteTurtle_RemovesTurtle()
//    {
//        // Arrange
//        var service = new TurtleService();
//
//        // Act
//        service.DeleteTurtle(1);
//
//        // Assert
//        Assert.Null(service.GetTurtleById(1));
//    }

using Lumivate.TurtleStore.Data;
using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Lumivate.TurtleStore.Tests
{
    // TODO-checkpoint-5: Uncomment and complete the test class above

    public class TurtleServiceTests
    {
        private TurtleStoreContext CreateContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<TurtleStoreContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;
            var context = new TurtleStoreContext(options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return context;
        }

        private TurtleStoreContext CreateSeededContext(string dbName)
        {
            var context = CreateContext(dbName);
            context.Turtles.AddRange(
                new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m, Description = "A friendly and curious turtle.", IsAvailable = true },
                new Turtle { Id = 2, Name = "Tank", Species = "Box Turtle", Price = 49.99m, Description = "A sturdy and calm companion.", IsAvailable = true },
                new Turtle { Id = 3, Name = "Speedy", Species = "Painted Turtle", Price = 24.99m, Description = "Surprisingly quick for a turtle!", IsAvailable = true }
            );
            context.SaveChanges();
            return context;
        }

        [Fact]
        public void GetAllTurtles_ReturnsAllTurtles()
        {
            // Arrange
            var context = CreateSeededContext("GetAllTurtles");
            var service = new TurtleService(context);

            // Act
            var result = service.GetAllTurtles();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void GetTurtleById_WithValidId_ReturnsTurtle()
        {
            // Arrange
            var context = CreateSeededContext("GetTurtleById_Valid");
            var service = new TurtleService(context);

            // Act
            var result = service.GetTurtleById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetTurtleById_WithInvalidId_ReturnsNull()
        {
            // Arrange
            var context = CreateSeededContext("GetTurtleById_Invalid");
            var service = new TurtleService(context);

            // Act
            var result = service.GetTurtleById(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddTurtle_IncreasesCount()
        {
            // Arrange
            var context = CreateSeededContext("AddTurtle");
            var service = new TurtleService(context);
            var initialCount = service.GetAllTurtles().Count;
            var newTurtle = new Turtle
            {
                Name = "Test Turtle",
                Species = "Test Species",
                Price = 9.99m,
                IsAvailable = true
            };

            // Act
            service.AddTurtle(newTurtle);

            // Assert
            Assert.Equal(initialCount + 1, service.GetAllTurtles().Count);
        }

        [Fact]
        public void DeleteTurtle_RemovesTurtle()
        {
            // Arrange
            var context = CreateSeededContext("DeleteTurtle");
            var service = new TurtleService(context);

            // Act
            service.DeleteTurtle(1);

            // Assert
            Assert.Null(service.GetTurtleById(1));
        }
    }
}
