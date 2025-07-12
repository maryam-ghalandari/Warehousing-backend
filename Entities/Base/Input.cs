using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Input : Thing
    {
        public required string Warehouseman { get; set; }
        public Product? Product { get; set; }
        public string? Equipment { get; set; }
        public int Offer { get; set; }
        public int Discoubt { get; set; }
        public DateTime InTime { get; set; } 
        public double InvoiceNumber { get; set; }
    }
}