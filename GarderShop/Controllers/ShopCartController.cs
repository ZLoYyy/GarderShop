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
    public class ShopCartController : Controller
    {
        private readonly IAllProducts _productsRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllProducts carRepository, ShopCart shopCart)
        {
            _productsRepository = carRepository;
            _shopCart = shopCart;
        }
        /// <summary>
        /// Вызываем шаблон
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            //Получаем товары
            var items = _shopCart.GetShopItems();
            //Задаем товары
            _shopCart.ListShortItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public void AddToCart(int id)
        {
            var item = _productsRepository.Products.FirstOrDefault(c => c.ID == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            //return RedirectToAction("Index");
        }
    }
}
