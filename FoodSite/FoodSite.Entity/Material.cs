using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Material : BaseEntity
    {
        public List<ProductMaterial> ProductMaterials { get; set; }
    }
}
