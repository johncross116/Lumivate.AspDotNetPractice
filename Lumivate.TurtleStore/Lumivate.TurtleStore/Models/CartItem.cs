namespace Lumivate.TurtleStore.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int TurtleId { get; set; }
        public Turtle? Turtle { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
