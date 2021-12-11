using GarderShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class Attribute : IAttribute
    {
        public int ID { get; set; }
        public string Caption { get; set; }
        public string Value { get; set; }
    }
}
