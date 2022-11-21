using FoodSite.Business.Abstract;
using FoodSite.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FoodSiteWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ProductList()
        {
            var products = await _productService.GetAllProductAsync(false);
            return View(products);
        }
        public async Task<IActionResult> ProductCreate() 
        {
            ViewBag.Categoires = await _categoryService.GetAllAsync();
            return View();
        }
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            await _productService.UpdateIsHomeAsync(product);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> UpdateIsApproved(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            await _productService.UpdateIsApprovedAsync(product);
            return RedirectToAction("ProductList");
        }
    }
}
