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
        public async Task<IEnumerable<Category>> AllCategoriesAsync()
        {
            return await _dBContent.Categories.ToListAsync();            
        }

        public async Task<IEnumerable<Category>> ParentCategoriesAsync()
        {
            return await _dBContent.Categories.Where(X => X.ParentID == null).ToListAsync();
        }

        public async Task<Category> CategoryByIDAsync(int id)
        {
            return await _dBContent.Categories.FirstOrDefaultAsync(category => category.ID == id);
        }

        public async Task<IEnumerable<Category>> ChildCategoriesAsync(int id) => await _dBContent.Categories.Where(category => category.ParentID == id).ToListAsync();

        public async Task SaveCategoryAsync(Category category)
        {
            _dBContent.Entry(category).State = EntityState.Added;
            await _dBContent.SaveChangesAsync();
        }
    }
}
