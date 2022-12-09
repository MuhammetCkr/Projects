using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesAsync();

    }
}
