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
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Product>> GetHomeProductAsync(string category)
        {
            return await _productRepository.GetHomeProductAsync(category);
        }

        public async Task<Product> GetProductDetails(string url)
        {
            return await _productRepository.GetProductDetails(url);
        }

        public async Task<List<Product>> GetProductsWithMaterialAsync()
        {
            return await _productRepository.GetProductsWithMaterialAsync();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
