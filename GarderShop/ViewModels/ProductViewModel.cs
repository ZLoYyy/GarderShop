using GarderShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.ViewModels
{
    public class ProductViewModel
    {
        public Product ProductByID { get; set; }

        public IEnumerable<Product> ProductsByCategory { get; set; }
    }
}
