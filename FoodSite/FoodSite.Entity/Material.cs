using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public List<FoodMaterial> FoodMaterials { get; set; }
    }
}
