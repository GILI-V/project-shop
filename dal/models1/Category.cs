using System;
using System.Collections.Generic;

namespace dal.models1;

public partial class Category
{
    public int CategoryCode { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
