using System;
using System.Collections.Generic;

namespace dal.models1;

public partial class Purchase
{
    public int PurchaseCode { get; set; }

    public int? CustomerCode { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Notes { get; set; }

    public virtual Customer? CustomerCodeNavigation { get; set; }

    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
}
