using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Client : Invoice
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string NationalCode { get; set; }
        public int Phone { get; set; } 
        public required double Mobile { get; set; }
        public string? Email { get; set; }     
        public required string HomeAddress { get; set; }
        public required string WorkAddress { get; set; }
    }
}