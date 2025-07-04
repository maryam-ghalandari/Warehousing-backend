using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warehousing_backend.Entities.Base
{
    public class Return : Inputs
    {
        public required DateTime OutTime { get; set; }
        public DateTime ReturnTime { get; set; }
    }
}