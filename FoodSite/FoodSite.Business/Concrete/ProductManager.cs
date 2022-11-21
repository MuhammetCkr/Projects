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

        public async Task CreateAsync(Product product, int[] categoryIds)
        {
            await _productRepository.CreateAsync(product, categoryIds);
        }

        public Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProductAsync(bool isDeleted)
        {
           return await _productRepository.GetAllProductAsync(isDeleted);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
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

        public async Task<List<Product>> GetSearchAsync(string search)
        {
            return await _productRepository.GetSearchAsync(search);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productRepository.UpdateIsHomeAsync(product);
        }

        public async Task UpdateIsApprovedAsync(Product product)
        {
            await _productRepository.UpdateIsApprovedAsync(product);
        }

        public async Task UpdateIsHomeAsync(Product product)
        {
           await _productRepository.UpdateIsHomeAsync(product);
        }
    }
}
