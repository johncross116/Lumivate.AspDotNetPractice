using Lumivate.TurtleStore.Services;

namespace Lumivate.TurtleStore.Tests.Services
{
    public class TurtleServiceTests
    {
        private readonly TurtleService _turtleService;

        public TurtleServiceTests()
        {
            _turtleService = new TurtleService();
        }

        [Fact]
        public void GetAllTurtles_ReturnsAllTurtles()
        {
            // Act
            var turtles = _turtleService.GetAllTurtles();

            // Assert
            Assert.NotNull(turtles);
            Assert.True(turtles.Count > 0);
        }

        [Fact]
        public void GetTurtleById_WithValidId_ReturnsTurtle()
        {
            // Act
            var turtle = _turtleService.GetTurtleById(1);

            // Assert
            Assert.NotNull(turtle);
            Assert.Equal(1, turtle.Id);
            Assert.Equal("Shelly", turtle.Name);
        }

        [Fact]
        public void GetTurtleById_WithInvalidId_ReturnsNull()
        {
            // Act
            var turtle = _turtleService.GetTurtleById(999);

            // Assert
            Assert.Null(turtle);
        }
    }
}
