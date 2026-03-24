using Lumivate.TurtleStore.Services;

namespace Lumivate.TurtleStore.Tests.Services
{
    public class CartServiceTests
    {
        private readonly CartService _cartService;
        private readonly TurtleService _turtleService;

        public CartServiceTests()
        {
            _turtleService = new TurtleService();
            _cartService = new CartService(_turtleService);
            _cartService.ClearCart();
        }

        [Fact]
        public void GetCartItems_WhenEmpty_ReturnsEmptyList()
        {
            // Act
            var items = _cartService.GetCartItems();

            // Assert
            Assert.NotNull(items);
            Assert.Empty(items);
        }

        [Fact]
        public void AddToCart_WithValidTurtle_AddsItem()
        {
            // Act
            _cartService.AddToCart(1);
            var items = _cartService.GetCartItems();

            // Assert
            Assert.Single(items);
            Assert.Equal(1, items[0].TurtleId);
        }

        [Fact]
        public void AddToCart_SameTurtleTwice_IncrementsQuantity()
        {
            // Act
            _cartService.AddToCart(1);
            _cartService.AddToCart(1);
            var items = _cartService.GetCartItems();

            // Assert
            Assert.Single(items);
            Assert.Equal(2, items[0].Quantity);
        }

        [Fact]
        public void RemoveFromCart_RemovesItem()
        {
            // Arrange
            _cartService.AddToCart(1);

            // Act
            _cartService.RemoveFromCart(1);
            var items = _cartService.GetCartItems();

            // Assert
            Assert.Empty(items);
        }

        [Fact]
        public void GetCartTotal_CalculatesCorrectly()
        {
            // Arrange
            _cartService.AddToCart(1); // Shelly: $29.99

            // Act
            var total = _cartService.GetCartTotal();

            // Assert
            Assert.Equal(29.99m, total);
        }

        [Fact]
        public void ClearCart_RemovesAllItems()
        {
            // Arrange
            _cartService.AddToCart(1);
            _cartService.AddToCart(2);

            // Act
            _cartService.ClearCart();
            var items = _cartService.GetCartItems();

            // Assert
            Assert.Empty(items);
        }
    }
}
