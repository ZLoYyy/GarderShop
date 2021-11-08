using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class PriductController1 : Controller
    {
        public IActionResult Index(int index)
        {
            return View();
        }
    }
}
