using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class FoodMaterial
    {
        public int FoodId { get; set; }
        public int MaterialId { get; set; }
        public Food Food { get; set; }
        public Material Material { get; set; }
    }
}
