using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Outputs
    {
        public required Product Productroduct { get; set; }
        public required string ClientName { get; set; }
        public double ClientPhone { get; set; }
        public required string Warehouseman { get; set; }
        public required int Number { get; set; }
        public required double Price { get; set; }
        public DateTime OutTime { get; set; }
        public double InvoiceNumber { get; set; }

    }
}