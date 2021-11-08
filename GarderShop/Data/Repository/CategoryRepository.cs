using GarderShop.Data.Interfaces;
using GarderShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Repository
{
    public class CategoryRepository: IAllCategory
    {
        private readonly DBConnect _dBContent;
        public CategoryRepository(DBConnect dBContent)
        {
            _dBContent = dBContent;
        }
        public IEnumerable<Category> AllCategories => _dBContent.Categories;

        public IEnumerable<Category> ParentCategories => _dBContent.Categories.Where(category => category.ParentID == null);

        public Category CategoryByID(int id) => _dBContent.Categories.FirstOrDefault(category => category.ID == id);
    }
}
