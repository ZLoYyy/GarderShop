using GarderShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class UserController : Controller
    {
        public UserController() 
        {

        }

        [HttpGet]
        [Route("Registration")]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Accept", user);
            }

            return View(user);
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}
