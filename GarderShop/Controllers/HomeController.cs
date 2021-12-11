using GarderShop.Data;
using GarderShop.Data.Interfaces;
using GarderShop.Models;
using GarderShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRepository;
        private readonly IAllCategory _categoryRepository;

        public HomeController(IAllProducts productRepository, IAllCategory categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<ViewResult> Index()
        {
            try
            {
                var homeProducts = new HomeViewModel
                {
                    FavProducts = _productRepository.GetFavProducts,
                    Categories = await _categoryRepository.AllCategoriesAsync()

                };
                return View(homeProducts);
            }
            catch
            {
                return View();
            }
        }
        [Route("About")]
        public IActionResult About()
        {
            ViewBag.Title = "О нас";
            return View();
        }
        [Route("Contacts")]
        public IActionResult Contacts()
        {
            ViewBag.Title = "Контакты";
            return View();
        }
    }
}
