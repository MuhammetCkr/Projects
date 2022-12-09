using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryPiece { get; set; }
        public string CategoryUrl { get; set; }
        public bool CategoryDeleted { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }
    }
}
