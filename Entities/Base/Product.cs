using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehousing_backend.Enums;

namespace warehousing_backend.Entities.Base
{
    public class Product : Thing
    {
        public required Categories Categories { get; set; }
        public required Brand Brand { get; set; }
        public String? Supplier { get; set; }
        public required string Title { get; set; }
        public double Inventory { get; set; }
        public double Price { get; set; }
        public int ValuAddedTax { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}