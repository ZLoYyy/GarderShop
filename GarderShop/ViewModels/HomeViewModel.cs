using GarderShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.ViewModels
{
    public class HomeViewModel
    {
        /// <summary>
        /// Популярные товары
        /// </summary>
        public IEnumerable<Product> FavProducts { get; set; }
        /// <summary>
        /// Категории
        /// </summary>
        public IEnumerable<Category> Categories { get; set; }
    }
}
