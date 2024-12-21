using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class PurchaseDto
    {
        public int PurchaseCode { get; set; }

        public int? CustomerCode { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? Notes { get; set; }
    }
}
