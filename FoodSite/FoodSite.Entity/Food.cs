using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodRecipe { get; set; }
        public string FoodImage { get; set; }
        public decimal FoodPuan { get; set; }
        public string FoodUrl { get; set; }
        public DateTime FoodDate { get; set; }
        public bool FoodDeleted { get; set; }
        public bool FoodApproved { get; set; }
        public bool FoodHome { get; set; }
        public string? FoodDetails { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }
        public List<FoodComment> FoodComments { get; set; }
        public List<FoodMaterial> FoodMaterials { get; set; }
    }
}
