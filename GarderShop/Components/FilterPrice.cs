﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Components
{
    public class FilterPrice: ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
