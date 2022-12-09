using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class FoodCategory
    {
        public int FoodId { get; set; }
        public int CategoryId { get; set; }
        public Food Food { get; set; }
        public Category Category { get; set; }
    }
}
