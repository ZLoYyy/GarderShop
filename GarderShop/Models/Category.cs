using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class Category
    {
        /// <summary>
        /// ИД категории
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ссылка на родительскую категорию
        /// </summary>
        public int? ParentID { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string Img { get; set; }
        /// <summary>
        /// Список товаров категории
        /// </summary>
        public virtual IEnumerable<Product> Products { get; set; }
        /// <summary>
        /// Список дочерних категорий
        /// </summary>
        public virtual IEnumerable<Category> ChildCategories { get; set; }
        /// <summary>
        /// Список атрибутов
        /// </summary>
        public virtual IEnumerable<CategoryAttribute> Attributes { get; set; }
    }
}
