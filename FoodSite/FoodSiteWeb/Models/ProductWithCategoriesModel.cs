using FoodSite.Entity;

namespace FoodSiteWeb.Models
{
    public class ProductWithCategoriesModel : BaseModel
    {
        public string Properties { get; set; }
        public string Recipe { get; set; }
        public string ImageUrl { get; set; }
        public List<Category> SelectedCategories { get; set; }

    }
}
