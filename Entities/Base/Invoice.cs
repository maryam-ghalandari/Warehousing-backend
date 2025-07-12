using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehousing_backend.Enums;

namespace warehousing_backend.Entities.Base
{
    public class Invoice : Thing
    {
        public required string SalesPersonName { get; set; }
        public required Client Client { get; set; }
        public required string Product { get; set; }
        public PayMethod PayMethod { get; set; }
        
    }
}