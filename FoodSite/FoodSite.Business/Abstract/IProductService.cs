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
        Task<List<Product>> GetAllProductAsync(bool isDeleted);
        Task CreateAsync (Product product, int[] categoryIds);
        Task<List<Product>> GetHomeProductAsync(string category);
        Task<List<Product>> GetProductsWithMaterialAsync();
        Task<Product> GetProductDetails(string url);
        Task<List<Product>> GetSearchAsync(string search);
        Task UpdateIsHomeAsync(Product product);
        Task UpdateIsApprovedAsync(Product product);
        #endregion
    }
}
