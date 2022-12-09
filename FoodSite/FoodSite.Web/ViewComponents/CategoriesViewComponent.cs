using FoodSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodSite.Web.ViewComponents
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
            var categories = await _categoryService.GetAllCategoriesAsync();
            return View(categories);
        }
    }
}
