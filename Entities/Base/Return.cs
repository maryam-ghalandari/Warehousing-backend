using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Return : Thing
    {
        public required Product Product { get; set; }
        public required Client Client { get; set; }
        public int Number { get; set; }
        public required DateTime InvoiceDate { get; set; }
        public DateTime ReturnTime { get; set; }
        public String? ReturnReason { get; set; }
    }
}