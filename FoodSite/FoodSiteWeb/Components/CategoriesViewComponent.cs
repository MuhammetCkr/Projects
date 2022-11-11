using FoodSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodSiteWeb.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategory = RouteData.Values["category"];
            }
            var categories = await _categoryService.GetAllCategoriesAsync();
            return View(categories);
        }
    }
}
