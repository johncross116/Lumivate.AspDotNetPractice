// TODO-checkpoint-5: Create unit tests for CartService using xUnit
//
// 1. Add the following using statements:
//    using Lumivate.TurtleStore.Models;
//    using Lumivate.TurtleStore.Services;
//    using Xunit;
//
// 2. Create a test class called CartServiceTests
//
// 3. Write the following test methods using the [Fact] attribute:
//
//    [Fact]
//    public void AddToCart_AddsItemToCart()
//    {
//        // Arrange
//        var turtleService = new TurtleService();
//        var cartService = new CartService(turtleService);
//
//        // Act
//        cartService.AddToCart(1);
//        var items = cartService.GetCartItems();
//
//        // Assert
//        Assert.Single(items);
//        Assert.Equal(1, items[0].TurtleId);
//    }
//
//    [Fact]
//    public void AddToCart_SameTurtleTwice_IncreasesQuantity()
//    {
//        // Arrange
//        var turtleService = new TurtleService();
//        var cartService = new CartService(turtleService);
//
//        // Act
//        cartService.AddToCart(1);
//        cartService.AddToCart(1);
//        var items = cartService.GetCartItems();
//
//        // Assert
//        Assert.Single(items);
//        Assert.Equal(2, items[0].Quantity);
//    }
//
//    [Fact]
//    public void RemoveFromCart_RemovesItem()
//    {
//        // Arrange
//        var turtleService = new TurtleService();
//        var cartService = new CartService(turtleService);
//        cartService.AddToCart(1);
//
//        // Act
//        cartService.RemoveFromCart(1);
//        var items = cartService.GetCartItems();
//
//        // Assert
//        Assert.Empty(items);
//    }
//
//    [Fact]
//    public void ClearCart_RemovesAllItems()
//    {
//        // Arrange
//        var turtleService = new TurtleService();
//        var cartService = new CartService(turtleService);
//        cartService.AddToCart(1);
//        cartService.AddToCart(2);
//
//        // Act
//        cartService.ClearCart();
//        var items = cartService.GetCartItems();
//
//        // Assert
//        Assert.Empty(items);
//    }

using Lumivate.TurtleStore.Data;
using Lumivate.TurtleStore.Models;
using Lumivate.TurtleStore.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Lumivate.TurtleStore.Tests
{
    // TODO-checkpoint-5: Uncomment and complete the test class above

    public class CartServiceTests
    {
        private TurtleStoreContext CreateSeededContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<TurtleStoreContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;
            var context = new TurtleStoreContext(options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Turtles.AddRange(
                new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Price = 29.99m, Description = "A friendly and curious turtle.", IsAvailable = true },
                new Turtle { Id = 2, Name = "Tank", Species = "Box Turtle", Price = 49.99m, Description = "A sturdy and calm companion.", IsAvailable = true }
            );
            context.SaveChanges();
            return context;
        }

        [Fact]
        public void AddToCart_AddsItemToCart()
        {
            // Arrange
            var context = CreateSeededContext("Cart_AddToCart");
            var cartService = new CartService(context);

            // Act
            cartService.AddToCart(1);
            var items = cartService.GetCartItems();

            // Assert
            Assert.Single(items);
            Assert.Equal(1, items[0].TurtleId);
        }

        [Fact]
        public void AddToCart_SameTurtleTwice_IncreasesQuantity()
        {
            // Arrange
            var context = CreateSeededContext("Cart_SameTurtleTwice");
            var cartService = new CartService(context);

            // Act
            cartService.AddToCart(1);
            cartService.AddToCart(1);
            var items = cartService.GetCartItems();

            // Assert
            Assert.Single(items);
            Assert.Equal(2, items[0].Quantity);
        }

        [Fact]
        public void RemoveFromCart_RemovesItem()
        {
            // Arrange
            var context = CreateSeededContext("Cart_RemoveFromCart");
            var cartService = new CartService(context);
            cartService.AddToCart(1);

            // Act
            cartService.RemoveFromCart(1);
            var items = cartService.GetCartItems();

            // Assert
            Assert.Empty(items);
        }

        [Fact]
        public void ClearCart_RemovesAllItems()
        {
            // Arrange
            var context = CreateSeededContext("Cart_ClearCart");
            var cartService = new CartService(context);
            cartService.AddToCart(1);
            cartService.AddToCart(2);

            // Act
            cartService.ClearCart();
            var items = cartService.GetCartItems();

            // Assert
            Assert.Empty(items);
        }
    }
}
