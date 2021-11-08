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
        private readonly IAllProducts _carRepository;

        public HomeController(IAllProducts carRepository)
        {
            _carRepository = carRepository;
        }

        public ViewResult Index()
        {

            try
            {
                var homeProducts = new HomeViewModel
                {
                    FavProducts = _carRepository.GetFavProducts
                };
                return View(homeProducts);
            }
            catch 
            {
                return View();
            }
        }
        /*public IActionResult Index() 
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { ID = 1, Name = "Телефоны" },
                new Category() { ID = 2, Name = "Samsung", ParentID = 1 },
                new Category() { ID = 3, Name = "Телевизоры" },
                new Category() { ID = 4, Name = "Ноутбуки" },
                new Category() { ID = 5, Name = "HP", ParentID = 4}
            };

            return View(categories);
        }*/

        public IActionResult Products()
        {
            Product iPhoneXS = new Product() { ID = 1, Name = "iPhone XS", Price = 27999 };
            return View(iPhoneXS);
        }

        public IActionResult Catalog()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { ID = 1, Name = "Телефоны" },
                new Category() { ID = 2, Name = "Samsung", ParentID = 1 },
                new Category() { ID = 3, Name = "Телевизоры" },
                new Category() { ID = 4, Name = "Ноутбуки" },
                new Category() { ID = 5, Name = "HP", ParentID = 4}
            };

            return View(categories);
        }

        public IActionResult About()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour > 12 ? "Good nigth": "Good morning";
            return View();
        }

        public IActionResult Contacts()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour > 12 ? "Good nigth" : "Good morning";
            return View();
        }
    }
}
