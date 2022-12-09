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
        public EfCoreMaterialRepository(FoodContext _dbContext):base(_dbContext) 
        { 

        }
        private FoodContext context
        {
            get
            {
                return _dbContext as FoodContext;
            }
        }
    }
}
