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

using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Xunit;

namespace Lumivate.TurtleStore.Tests
{
    // TODO-checkpoint-5: Uncomment and complete the test class above

    public class TurtleServiceTests
    {
        [Fact]
        public void GetAllTurtles_ReturnsAllTurtles()
        {
            // Arrange
            var service = new TurtleService();

            // Act
            var result = service.GetAllTurtles();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetTurtleById_WithValidId_ReturnsTurtle()
        {
            // Arrange
            var service = new TurtleService();

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
            var service = new TurtleService();

            // Act
            var result = service.GetTurtleById(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddTurtle_IncreasesCount()
        {
            // Arrange
            var service = new TurtleService();
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
            var service = new TurtleService();

            // Act
            service.DeleteTurtle(1);

            // Assert
            Assert.Null(service.GetTurtleById(1));
        }
    }
}
