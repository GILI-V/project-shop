using System;
using System.Collections.Generic;

namespace dal.models1;

public partial class Company
{
    public int CompanyCode { get; set; }

    public string CompanyName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
