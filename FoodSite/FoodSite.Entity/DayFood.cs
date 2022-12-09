using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class DayFood
    {
        public int DayFoodId { get; set; }
        public string DayFoodName { get; set; }
        public string DayFoodRecipe { get; set; }
        public string DayFoodMaterials { get; set; }
        public decimal DayFoodPuan { get; set; }
        public DateTime DayFoodDate { get; set; }
    }
}
