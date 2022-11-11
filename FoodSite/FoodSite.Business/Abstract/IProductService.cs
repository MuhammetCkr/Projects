using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Business.Abstract
{
    public interface IProductService
    {
        #region Generic
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        #endregion

        #region Product
        Task<List<Product>> GetHomeProductAsync(string category);
        Task<List<Product>> GetProductsWithMaterialAsync();
        Task<Product> GetProductDetails(string url);
        #endregion
    }
}
