using System;

namespace Core.Models
{
    public class ManufacturerContact
    {
        public int ManufacturerContactId { get; set; }
        public string AddressLine01 { get; set; }
        public string AddressLine02 { get; set; }
        public string AddressLine03 { get; set; }
        public string AddressLine04 { get; set; }
        public string AddressLine05 { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
