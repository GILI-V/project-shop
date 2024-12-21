using System;
using System.Collections.Generic;

namespace dal.models1;

public partial class Product
{
    public int ProductCode { get; set; }

    public string ProductName { get; set; } = null!;

    public int? CategoryCode { get; set; }

    public int? CompanyCode { get; set; }

    public string? ProductDescription { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdated { get; set; }

    public virtual Category? CategoryCodeNavigation { get; set; }

    public virtual Company? CompanyCodeNavigation { get; set; }

    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
}
