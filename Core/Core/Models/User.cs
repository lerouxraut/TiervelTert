using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public Guid object_id { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
