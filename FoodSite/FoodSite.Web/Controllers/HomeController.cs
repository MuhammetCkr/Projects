using FoodSite.Business.Abstract;
using FoodSite.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodService _foodService;

        public HomeController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var foods = await _foodService.GetHomeFoodAsync(id);
            return View(foods);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
