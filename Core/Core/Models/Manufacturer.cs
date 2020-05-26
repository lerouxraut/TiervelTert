using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string ManufacturerNumber { get; set; }

        public string ManufacturerDescription { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
