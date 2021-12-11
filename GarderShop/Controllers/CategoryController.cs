using GarderShop.Data.Interfaces;
using GarderShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        [Route("Categories")]
        public async Task<IActionResult> Index()
        {

            var categories = new CategoryViewModel
            {
                Categories = await _allCategory.AllCategoriesAsync(),
                ParentCategories = await _allCategory.ParentCategoriesAsync()
            };

            return View(categories);
        }
        [Route("Categories/Products")]
        public async Task<IActionResult> ProductsByID(int id) 
        {
            //Проверяем на наличие подкатегорий
            var childCategories = await _allCategory.ChildCategoriesAsync(id);
            if (childCategories != null && childCategories.Count() > 0) 
            {
                var categories = new CategoryViewModel
                {
                    ParentCategories = childCategories
                };

                return View("index", categories);
            }
            //Выдаем список товаров
            var productsByCategory = new ProductViewModel
            {
                ProductsByCategory = _allProducts.Products.Where(product => product.CategoryID == id)
            };
            return View(productsByCategory);
        }
    }
}
