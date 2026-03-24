using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public class TurtleService : ITurtleService
    {
        // In-memory list of turtles (this will be replaced with a database in later modules)
        private static readonly List<Turtle> _turtles = new List<Turtle>
        {
            new Turtle { Id = 1, Name = "Shelly", Species = "Red-Eared Slider", Description = "A friendly and active turtle who loves basking under the heat lamp. Great for beginners!", Price = 29.99m, ImageUrl = "/images/turtle1.png", IsAvailable = true },
            new Turtle { Id = 2, Name = "Speedy", Species = "Eastern Box Turtle", Description = "Surprisingly quick on his feet. Enjoys exploring and is very curious about the world around him.", Price = 49.99m, ImageUrl = "/images/turtle2.png", IsAvailable = true },
            new Turtle { Id = 3, Name = "Tank", Species = "Sulcata Tortoise", Description = "A gentle giant. Tank loves munching on leafy greens and will grow to be quite large!", Price = 149.99m, ImageUrl = "/images/turtle3.png", IsAvailable = true },
            new Turtle { Id = 4, Name = "Pearl", Species = "Painted Turtle", Description = "Beautifully colored with vibrant markings. Pearl is calm and easy to care for.", Price = 39.99m, ImageUrl = "/images/turtle4.png", IsAvailable = true },
            new Turtle { Id = 5, Name = "Mossy", Species = "Mata Mata Turtle", Description = "An exotic and unique-looking turtle with a leaf-shaped head. A conversation starter!", Price = 199.99m, ImageUrl = "/images/turtle5.png", IsAvailable = false },
            new Turtle { Id = 6, Name = "Bubbles", Species = "Mississippi Map Turtle", Description = "Loves swimming and is very entertaining to watch in the water. A great aquatic companion.", Price = 34.99m, ImageUrl = "/images/turtle6.png", IsAvailable = true }
        };

        public List<Turtle> GetAllTurtles()
        {
            return _turtles;
        }

        public Turtle? GetTurtleById(int id)
        {
            return _turtles.FirstOrDefault(t => t.Id == id);
        }
    }
}
