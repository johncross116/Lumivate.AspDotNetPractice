using Lumivate.TurtleStore.Controllers;
using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Lumivate.TurtleStore.Tests.Controllers
{
    public class TurtlesControllerTests
    {
        private readonly Mock<ITurtleService> _mockTurtleService;
        private readonly TurtlesController _controller;

        public TurtlesControllerTests()
        {
            _mockTurtleService = new Mock<ITurtleService>();
            _controller = new TurtlesController(_mockTurtleService.Object);
        }

        [Fact]
        public void Index_ReturnsViewWithTurtles()
        {
            // Arrange
            var turtles = new List<Turtle>
            {
                new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m },
                new Turtle { Id = 2, Name = "Speedy", Species = "Box Turtle", Price = 49.99m }
            };
            _mockTurtleService.Setup(s => s.GetAllTurtles()).Returns(turtles);

            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = result.Model as List<Turtle>;
            Assert.NotNull(model);
            Assert.Equal(2, model.Count);
        }

        [Fact]
        public void Details_WithValidId_ReturnsViewWithTurtle()
        {
            // Arrange
            var turtle = new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m };
            _mockTurtleService.Setup(s => s.GetTurtleById(1)).Returns(turtle);

            // Act
            var result = _controller.Details(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = result.Model as Turtle;
            Assert.NotNull(model);
            Assert.Equal("Shelly", model.Name);
        }

        [Fact]
        public void Details_WithInvalidId_ReturnsNotFound()
        {
            // Arrange
            _mockTurtleService.Setup(s => s.GetTurtleById(999)).Returns((Turtle?)null);

            // Act
            var result = _controller.Details(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
