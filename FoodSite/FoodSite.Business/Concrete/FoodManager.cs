using FoodSite.Business.Abstract;
using FoodSite.Data.Abstract;
using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodManager(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task FoodCreateAsync(Food food, int[] categorIds, int[] materialIds)
        {
            await _foodRepository.FoodCreateAsync(food, categorIds, materialIds);
        }

        public async Task<List<Food>> GetFoodUnListAsync(bool isHome, bool isApproved)
        {
            return await _foodRepository.GetFoodUnListAsync(isHome, isApproved);
        }

        public async Task<Food> GetFoodDetailsAsync(int id)
        {
            return await _foodRepository.GetFoodDetailsAsync(id);
        }

        public async Task<Food> GetFoodEditAsync(int id)
        {
            return await _foodRepository.GetFoodEditAsync(id);
        }

        public async Task<List<Food>> GetFoodWithCategoriesAsync(string category)
        {
            return await _foodRepository.GetFoodWithCategoriesAsync(category);
        }

        public async Task<List<Food>> GetHomeFoodAsync(int id)
        {
            return await _foodRepository.GetHomeFoodAsync(id);
        }
    }
}
