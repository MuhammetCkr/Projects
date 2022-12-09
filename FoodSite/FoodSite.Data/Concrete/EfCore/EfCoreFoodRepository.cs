using FoodSite.Data.Abstract;
using FoodSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Concrete.EfCore
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfCoreFoodRepository(FoodContext _dbContext) : base(_dbContext)
        {
        }
        private FoodContext context
        {
            get
            {
                return _dbContext as FoodContext;
            }
        }

        public async Task FoodCreateAsync(Food food, int[] categoryIds, int[] materialIds)
        {
            await context.Foods.AddAsync(food);
            await context.SaveChangesAsync();
            food.FoodCategories = categoryIds
                .Select(catId => new FoodCategory
                {
                    CategoryId = catId,
                    FoodId = food.FoodId
                }).ToList();
            food.FoodMaterials = materialIds
                .Select(matId => new FoodMaterial
                {
                    FoodId = food.FoodId,
                    MaterialId = matId
                }).ToList();
            await context.SaveChangesAsync();

        }

        public async Task<Food> GetFoodDetailsAsync(int id)
        {
            return await context
                .Foods
                .Where(f => f.FoodId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<Food> GetFoodEditAsync(int id)
        {
            return await context
                .Foods
                .Where(f => f.FoodId == id)
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .Include(x => x.FoodMaterials)
                .ThenInclude(fm => fm.Material)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Food>> GetFoodUnListAsync(bool isHome, bool isApproved)
        {
            return await context
                .Foods
                .Where(f => f.FoodHome == false && f.FoodApproved == false)
                .ToListAsync();
        }

        public async Task<List<Food>> GetFoodWithCategoriesAsync(string category)
        {
            var foods = context
                .Foods
                .Where(f => f.FoodHome && f.FoodApproved && f.FoodDeleted == false)
                .AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                foods = foods
                    .Include(f => f.FoodCategories)
                    .ThenInclude(fc => fc.Category)
                    .Where(f => f.FoodCategories.Any(fc => fc.Category.CategoryUrl == category));
            }
            return await foods.ToListAsync();

        }

        public async Task<List<Food>> GetHomeFoodAsync(int id)
        {
            return await context
                .Foods
                .Where(f => f.FoodDeleted == false && f.FoodHome == true)
                .ToListAsync();
        }
    }
}
