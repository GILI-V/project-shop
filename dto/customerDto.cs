using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class customerDto
    {
        public int CustomerCode { get; set; }

        public string CustomerName { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public DateOnly? BirthDate { get; set; }

    }
}

