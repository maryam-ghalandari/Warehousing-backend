using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Inputs
    {
        public required Product Productroduct { get; set; }
        public required string CompanyName { get; set; }
        public required string SalesPersonName { get; set; }
        public required string SalesPersonPhon{ get; set; }
        public required string Warehouseman { get; set; }
        public required int Number { get; set; }
        public required double Price { get; set; }
        public int Offer { get; set; }
        public int Discoubt { get; set; }
        public DateTime InTime { get; set; } 
        public double InvoiceNumber { get; set; }
    }
}