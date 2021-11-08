using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data
{
    public class DBObjects
    {
        public static void Inital(DBConnect content)
        {
            ///Проверка на наличие
            /*if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(item => item.Value));

            if (!content.Car.Any())
                content.Car.AddRange(Cars.Select(item => item.Value));*/

            content.SaveChanges();
        }
    }
}
