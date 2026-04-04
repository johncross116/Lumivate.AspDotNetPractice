// TODO-checkpoint-6 part F: Create unit tests for CartService using xUnit
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

namespace Lumivate.TurtleStore.Tests
{
    // TODO-checkpoint-6 part F: Uncomment and complete the test class above
}
