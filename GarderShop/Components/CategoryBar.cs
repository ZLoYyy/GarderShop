using GarderShop.Data.Interfaces;
using GarderShop.Data.Repository;
using GarderShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Components
{
    public class CategoryBar: ViewComponent
    {
        private readonly IAllCategory _categoryRepository;

        public CategoryBar(IAllCategory categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            List<Category> categories = new List<Category>();
            foreach (Category category in await _categoryRepository.AllCategoriesAsync())
            {
                category.ChildCategories = await _categoryRepository.ChildCategoriesAsync(category.ID);
                if (category.ParentID == null)
                {
                    categories.Add(category);
                }
            }
            return await Task.FromResult<IViewComponentResult>(View("_LeftBar", categories));
        }
    }
}
