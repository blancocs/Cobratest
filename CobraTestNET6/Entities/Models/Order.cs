using System;
using System.Collections.Generic;

namespace CobraTestNET6.Entities.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int PersonId { get; set; }

    public DateTime DateCreated { get; set; }

    public string MethodOfPurchase { get; set; } = null!;

    public virtual ICollection<OrdersDetail> OrdersDetails { get; } = new List<OrdersDetail>();

    public virtual Customer Person { get; set; } = null!;
}
