using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Supplier : Thing
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required double Mobile { get; set; }
        public int Phone { get; set; }
        // public EmailAddressAttribute? Email { get; set; }
        public required string Address { get; set; }
    }
}