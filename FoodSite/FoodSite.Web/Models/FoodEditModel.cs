using FoodSite.Entity;
using System.ComponentModel.DataAnnotations;

namespace FoodSite.Web.Models
{
    public class FoodEditModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim girinis!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "5 - 100")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yemeğin yapılışını yazınız!")]
        [StringLength(1000, MinimumLength = 5)]
        public string Recipe { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public List<Category> SelectedCategories { get; set; }
        public List<Material> SelectedMaterials { get; set; }
    }
}
