using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> expression);

    }
}
