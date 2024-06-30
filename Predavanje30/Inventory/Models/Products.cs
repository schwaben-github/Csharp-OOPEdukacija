using System;
using System.Collections.Generic;

namespace Inventory.Models;

public partial class Products
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public virtual Categories? Category { get; set; }
}
