using System;
using System.Collections.Generic;

namespace CobraTestNET6.Entities.Models;

public partial class OrdersDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public string ProductNumber { get; set; } = null!;

    public long ProductId { get; set; }

    public string ProductOrigin { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
