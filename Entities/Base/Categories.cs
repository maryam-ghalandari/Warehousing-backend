using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehousing_backend.Enums;

namespace warehousing_backend.Entities.Base
{
    public class Categories
    {
        public Brands Brands { get; set; }
        public Skin Skin { get; set; }
        public Hair Hair { get; set; }
        public Instruments Instruments { get; set; }
        public Perfume perfume { get; set; }
        public Supplements Supplements { get; set; }
    }
}