namespace dto
{
    public class productDto
    {

        public int ProductCode { get; set; }

        public string ProductName { get; set; } = null!;

        public int? CategoryCode { get; set; }

        public int? CompanyCode { get; set; }

        public string? ProductDescription { get; set; }

        public decimal Price { get; set; }

        public DateTime? LastUpdated { get; set; }

        public string? CategoryName { get; set; }
       
    }
}

