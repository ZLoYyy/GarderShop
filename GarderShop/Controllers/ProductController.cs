using GarderShop.Data.Interfaces;
using GarderShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts _productRepository;
        public ProductController(IAllProducts productRepository) 
        {
            _productRepository = productRepository;
        }
        public IActionResult ProductDetail(int index)
        {
            if (index == 0)
                return View("404");
            Product mainProduct = _productRepository.Products.FirstOrDefault(product => product.ID == index);
            return View(mainProduct);
        }
    }
}
