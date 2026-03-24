using Lumivate.TurtleStore.Models;

namespace Lumivate.TurtleStore.Services
{
    public interface ITurtleService
    {
        List<Turtle> GetAllTurtles();
        Turtle? GetTurtleById(int id);
    }
}
