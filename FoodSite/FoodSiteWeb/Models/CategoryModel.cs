using FoodSite.Entity;

namespace FoodSiteWeb.Models
{
    public class CategoryModel : BaseModel
    {
        public List<Product> Products { get; set; }
    }
}
