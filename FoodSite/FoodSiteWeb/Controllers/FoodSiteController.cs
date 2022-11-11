using FoodSite.Business.Abstract;
using FoodSite.Entity;
using FoodSiteWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodSiteWeb.Controllers
{
    public class FoodSiteController : Controller
    {
        private IProductService _productService;

        public FoodSiteController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Details(string url)
        {
            
            if (string.IsNullOrEmpty(url))
            {

                return NotFound();
            }
            Product product = await _productService.GetProductDetails(url);
            ProductDetailModel productDetailModel = new ProductDetailModel()
            {
                Product = product,
                Materials = product
                .ProductMaterials
                .Select(pm => pm.Material)
                .ToList()
            };
            return View(productDetailModel);
        }
    }
}
