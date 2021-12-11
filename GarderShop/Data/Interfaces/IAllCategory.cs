using GarderShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Interfaces
{
    public interface IAllCategory
    {
        Task<IEnumerable<Category>> AllCategoriesAsync();
        Task<IEnumerable<Category>> ParentCategoriesAsync();
        Task<IEnumerable<Category>> ChildCategoriesAsync(int id);
        Task<Category> CategoryByIDAsync(int id);
        Task SaveCategoryAsync(Category category);
    }
}
