using System;

namespace Core.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductNumber { get; set; }

        public string ProductDescription { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
