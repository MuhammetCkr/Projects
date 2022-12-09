using FoodSite.Business.Abstract;
using FoodSite.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FoodSite.Web.Controllers
{
    public class FoodController : Controller
    {
        private IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var foods = await _foodService.GetHomeFoodAsync(id);
            return View(foods);
        }
        public async Task<IActionResult> Details(int id)
        {
            var details = await _foodService.GetFoodDetailsAsync(id);
            return View(details);
        }
        public async Task<IActionResult> FoodList(string category)
        {
            var foodCategories = await _foodService.GetFoodWithCategoriesAsync(category);
            return View(foodCategories);
        }
    }
}
