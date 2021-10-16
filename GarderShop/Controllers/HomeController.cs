using GarderShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Products()
        {
            Product iPhoneXS = new Product() { ID = 1, Name = "iPhone XS", Price = 27999 };
            return View(iPhoneXS);
        }

        public IActionResult Hello()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour > 12 ? "Good nigth": "Good morning";
            return View();
        }
    }
}
