namespace CobraTestNET6.DTOs
{
    public class CarDTO
    {
        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }
        public int Doors { get; set; }

        public string Color { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
