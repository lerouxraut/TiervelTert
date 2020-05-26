using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        
        public int ProductId { get; set; }
        
        public int CategoryId { get; set; }
    }
}
