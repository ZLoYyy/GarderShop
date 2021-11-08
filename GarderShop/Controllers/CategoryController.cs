using GarderShop.Data.Interfaces;
using GarderShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class CategoryController : Controller
    {
        private IAllCategory _allCategory;
        private IAllProducts _allProducts;

        public CategoryController(IAllCategory allCategory, IAllProducts allProducts)
        {
            _allCategory = allCategory;
            _allProducts = allProducts;
        }
        public IActionResult Index()
        {
            var categories = new CategoryViewModel
            {
                Categories = _allCategory.AllCategories,
                ParentCategories = _allCategory.ParentCategories
            };

            return View(categories);
        }

        public IActionResult ProductsByID(int id) 
        {
            var productsByCategory = new ProductViewModel
            {
                ProductsByCategory = _allProducts.Products.Where(product => product.CategoryID == id)
            };
            return View(productsByCategory);
        }
    }
}
