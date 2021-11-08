using GarderShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Data.Interfaces
{
    public interface IAllCategory
    {
        IEnumerable<Category> AllCategories { get; }
        IEnumerable<Category> ParentCategories { get; }
        Category CategoryByID(int id);
    }
}
