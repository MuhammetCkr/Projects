using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Abstract
{
    public interface IFoodRepository : IRepository<Food>
    {
        Task<List<Food>> GetHomeFoodAsync(int id);
        Task<Food> GetFoodDetailsAsync(int id);
        Task<List<Food>> GetFoodWithCategoriesAsync(string category);
        Task<Food> GetFoodEditAsync(int id);
        Task FoodCreateAsync(Food food, int[] categoryIds, int[] materialIds);
        Task<List<Food>> GetFoodUnListAsync(bool isHome, bool isApproved);

    }
}
