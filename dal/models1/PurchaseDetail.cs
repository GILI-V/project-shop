using System;
using System.Collections.Generic;

namespace dal.models1;

public partial class PurchaseDetail
{
    public int PurchaseDetailCode { get; set; }

    public int? PurchaseCode { get; set; }

    public int? ProductCode { get; set; }

    public int Quantity { get; set; }

    public virtual Product? ProductCodeNavigation { get; set; }

    public virtual Purchase? PurchaseCodeNavigation { get; set; }
}
