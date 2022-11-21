using FoodSite.Data.Abstract;
using FoodSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(FoodSiteContext _dbContext) : base(_dbContext)
        {
        }
        private FoodSiteContext context
        {
            get
            {
                return _dbContext as FoodSiteContext;
            }
        }

        public async Task CreateAsync(Product product, int[] categoryIds)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            product.ProductCategories = categoryIds
                .Select(catId => new ProductCategory
                { 
                    ProductId = product.Id,
                    CategoryId = catId,
                }).ToList();
            await context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProductAsync(bool isDeleted)
        {
            return await context
                .Products
                .Where(p => p.IsDeleted == isDeleted)
                .ToListAsync();
        }

        public async Task<List<Product>> GetHomeProductAsync(string category)
        {
            var products = context
                .Products
                .Where(p => p.IsHome == true && p.IsApproved == true && p.IsDeleted == false)
                .AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(c => c.ProductCategories.Any(pc => pc.Category.Url== category));
            }
            return await products.ToListAsync();
        }

        public async Task<Product> GetProductDetails(string url)
        {
            return await context
                .Products
                .Where(p => p.Url == url)
                .Include(p => p.ProductMaterials)
                .ThenInclude(pc => pc.Material)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetProductsWithMaterialAsync()
        {

            return await context
                .Products
                .Include(p => p.ProductMaterials)
                .ThenInclude(pm => pm.Material)
                .ToListAsync();

        }

        public async Task<List<Product>> GetSearchAsync(string search)
        {
            var a = await context
                .Products
                .Where(p => p.IsApproved && p.IsDeleted == false && (p.Name.ToLower().Contains(search.ToLower()))).ToListAsync();
            return a;
        }

        public async Task UpdateIsApprovedAsync(Product product)
        {
            product.IsApproved = product.IsApproved ? false : true;
            context.Entry(product).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task UpdateIsHomeAsync(Product product)
        {
            product.IsHome = product.IsHome ? false : true;
            context.Entry(product).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
