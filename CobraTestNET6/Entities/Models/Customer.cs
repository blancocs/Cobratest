using System;
using System.Collections.Generic;

namespace CobraTestNET6.Entities.Models;

public partial class Customer
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public string? Ocuppation { get; set; }

    public string? MaritalStatus { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
