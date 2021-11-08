using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class ShopCart
    {
        /// <summary>
        /// Для работы с бд
        /// </summary>
        private readonly DBConnect _dBContent;
        public ShopCart(DBConnect dBContent)
        {
            _dBContent = dBContent;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopCartID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ShopCartItem> ListShortItems { get; set; }
        /// <summary>
        /// Для проверки наличия добавленного товара
        /// </summary>
        public static ShopCart GetCart(IServiceProvider services)
        {
            //Сессия
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DBConnect>();
            //берем/задаем ид
            string shopCartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", shopCartID);

            return new ShopCart(context) { ShopCartID = shopCartID };
        }

        public void AddToCart(Product product)
        {
            this._dBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartID = ShopCartID,
                Product = product,
                Price = product.Price
            });

            _dBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _dBContent.ShopCartItem.Where(c => c.ShopCartID == ShopCartID).Include(s => s.Product).ToList();
        }
    }
}
