using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Interfaces
{
    interface IAttribute
    {
        public int ID { get; set; }

        public string Caption { get; set; }

        public string Value { get; set; }
    }
}
