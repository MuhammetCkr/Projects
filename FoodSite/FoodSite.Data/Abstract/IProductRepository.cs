using FoodSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetHomeProductAsync(string category);
        Task<List<Product>> GetProductsWithMaterialAsync();
        Task<Product> GetProductDetails(string url);

    }
}
