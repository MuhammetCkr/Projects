using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Abstract
{
    public interface IRepository<TEntity>
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> expression);
        Task<List<TEntity>> GetAllAsync();
    }
}
