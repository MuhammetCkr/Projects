using FoodSite.Business.Abstract;
using FoodSiteWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodSiteWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(string category)
        {
            var homeProduct = await _productService.GetHomeProductAsync(category);
            return View(homeProduct);
        }
        //public async Task<IActionResult> ProductList(string category)
        //{
        //    var categoryProduct = await _productService.GetProductsWithCategoryAsync(category);
        //    return View("Index",categoryProduct);
        //}
    }
}