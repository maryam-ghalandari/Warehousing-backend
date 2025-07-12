using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehousing_backend.Enums;

namespace warehousing_backend.Entities.Base
{
    public class Categories : Thing
    {
        public Skin Skin { get; set; }
        public Hair Hair { get; set; }
        public Perfume Perfume { get; set; }
        public Supplements Tools { get; set; }
    }
}