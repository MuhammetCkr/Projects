using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Product : BaseEntity
    {
        public string Recipe { get; set; }
        public string Properties { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductComment> ProductComments { get; set; }
        public List<ProductMaterial> ProductMaterials { get; set; }
    }
}
