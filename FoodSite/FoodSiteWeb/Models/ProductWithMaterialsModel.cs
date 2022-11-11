using FoodSite.Entity;

namespace FoodSiteWeb.Models
{
    public class ProductWithMaterialsModel : BaseModel
    {
        public string Properties { get; set; }
        public string Recipe { get; set; }
        public string ImageUrl { get; set; }
        public List<Material> Materials { get; set; }
    }
}
