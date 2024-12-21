using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class PurchaseDetailDto
    {
        public int PurchaseDetailCode { get; set; }

        public int? PurchaseCode { get; set; }

        public int? ProductCode { get; set; }

        public int Quantity { get; set; }
    }
}
