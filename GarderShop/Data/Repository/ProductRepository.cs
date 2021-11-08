using GarderShop.Data.Interfaces;
using GarderShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly DBConnect _dBContent;

        public ProductRepository(DBConnect dBContent)
        {
            _dBContent = dBContent;
        }
        public IEnumerable<Product> Products => _dBContent.Products.Include(category => category.Category);

        public IEnumerable<Product> GetFavProducts => _dBContent.Products.Where(product => product.IsFavorite).Include(category => category.Category);

        public Product GetProductByID(int productID) => _dBContent.Products.FirstOrDefault(product => product.ID == productID);
    }
}
