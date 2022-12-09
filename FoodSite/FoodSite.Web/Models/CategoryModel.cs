using FoodSite.Entity;

namespace FoodSite.Web.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }
        public bool CategoryDeleted { get; set; }
        public List<Food> Foods { get; set; }
    }
}
