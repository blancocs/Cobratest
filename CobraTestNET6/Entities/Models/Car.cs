using System;
using System.Collections.Generic;
using CobraTestNET6.Entities.Models;

namespace CobraTestNET6.Entities.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }
    public int Doors { get; set; }

    public string Color { get; set; } = null!;

    public decimal Price { get; set; }
}
