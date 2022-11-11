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
    public class EfCoreMaterialRepository : EfCoreGenericRepository<Material>, IMaterialRepository
    {
        public EfCoreMaterialRepository(FoodSiteContext dbContext) : base(dbContext)
        {
        }
        private FoodSiteContext context
        {
            get
            {
                return _dbContext as FoodSiteContext;
            }
        }

    }
}
