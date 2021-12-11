using GarderShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class CategoryAttribute : Attribute
    {
        public int CategoryID { get; set; }
    }
}
