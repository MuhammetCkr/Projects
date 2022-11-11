using FoodSite.Entity;

namespace FoodSiteWeb.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Material> Materials { get; set; }
    }
}
