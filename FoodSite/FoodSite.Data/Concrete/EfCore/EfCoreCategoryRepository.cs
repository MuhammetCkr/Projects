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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        private FoodSiteContext context
        {
            get
            {
                return _dbContext as FoodSiteContext;
            }
        }
        public EfCoreCategoryRepository(FoodSiteContext _dbContext) : base(_dbContext)
        {
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await context
                .Categories
                .ToListAsync();
        }


    }
}
