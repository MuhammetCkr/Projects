using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Abstract
{
    public interface IMaterialService
    {
        Task<List<Material>> GetAllAsync(Expression<Func<Material, bool>> expression);
        Task<List<Material>> GetAllAsync();
    }
}
