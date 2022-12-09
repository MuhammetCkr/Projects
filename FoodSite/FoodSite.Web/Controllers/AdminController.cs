using FoodSite.Business.Abstract;
using FoodSite.Core;
using FoodSite.Entity;
using FoodSite.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodSite.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;
        private readonly IMaterialService _materialService;

        public AdminController(IFoodService foodService, ICategoryService categoryService, IMaterialService materialService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
            _materialService = materialService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FoodEdit(int id)
        {
            var food = await _foodService.GetFoodEditAsync(id);
            FoodEditModel foodEditModel = new FoodEditModel()
            {
                Id = food.FoodId,
                Name = food.FoodName,
                Image = food.FoodImage,
                IsHome = food.FoodHome,
                IsApproved = food.FoodApproved,
                Recipe = food.FoodRecipe,
                SelectedCategories = food
                .FoodCategories
                .Select(fc => fc.Category)
                .ToList(),
                SelectedMaterials = food
                .FoodMaterials
                .Select(fc => fc.Material)
                .ToList()
            };

            ViewBag.Categories = await _categoryService.GetAllAsync(c => c.CategoryDeleted == false);
            ViewBag.Materials = await _materialService.GetAllAsync();
            return View(foodEditModel);
        }
        public async Task<IActionResult> FoodList(int id)
        {
            var foods = await _foodService.GetHomeFoodAsync(id);
            return View(foods);
        }
        public async Task<IActionResult> FoodCreate()
        {
            ViewBag.Categories = await _categoryService.GetAllAsync(c => c.CategoryDeleted == false);
            ViewBag.Materials = await _materialService.GetAllAsync();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FoodCreate(FoodEditModel foodModel, IFormFile file, int[] categoryIds, int[] materialIds)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && materialIds.Length > 0)
            {
                var url = Jobs.MakeUrl(foodModel.Id + foodModel.Name);
                Food food = new Food()
                {
                    FoodName = foodModel.Name,
                    FoodRecipe = foodModel.Recipe,
                    FoodImage = Jobs.UploadImage(file, url),
                    FoodUrl = url,
                    FoodHome = foodModel.IsHome,
                    FoodApproved = foodModel.IsApproved
                };
                await _foodService.FoodCreateAsync(food, categoryIds, materialIds);
                return RedirectToAction("FoodList");
            }
            if (categoryIds.Length == 0)
            {
                ViewBag.CategoryErrorMessage = "Lütfen kategori seç!";
            }
            else if (materialIds.Length == 0)
            {
                ViewBag.MaterialErrorMessage = "Lütfen material seç!";
            }
            else
            {
                ViewData["SelectedCategories"] = categoryIds;
                ViewData["SelectedMaterials"] = materialIds;
            }
            ViewBag.Categories = await _categoryService.GetAllAsync(c => c.CategoryDeleted == false);
            ViewBag.Materials = await _materialService.GetAllAsync();
            return View(foodModel);
        }
        public async Task<IActionResult> FoodUnList(bool isHome, bool isApproved)
        {
            var foodUnList = await _foodService.GetFoodUnListAsync(isHome, isApproved);
            return View(foodUnList);
        }
    }
}
