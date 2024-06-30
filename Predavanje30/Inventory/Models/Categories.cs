using System;
using System.Collections.Generic;

namespace Inventory.Models;

public partial class Categories
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
