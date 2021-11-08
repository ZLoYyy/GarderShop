using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class ShopCartItem
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public string ShopCartID { get; set; }
    }
}
