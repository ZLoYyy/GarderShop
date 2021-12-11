using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Img { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }        
        public virtual IEnumerable<ProductAttribute> Attributes { get; set; }
    }
}
