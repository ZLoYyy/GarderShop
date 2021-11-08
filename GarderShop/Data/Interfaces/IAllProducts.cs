using GarderShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; /*set;*/ }

        IEnumerable<Product> GetFavProducts { get; /*set; */}

        Product GetProductByID(int productID);
    }
}
