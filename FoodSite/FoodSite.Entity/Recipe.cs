using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeMaterials { get; set; }
        public string RecipeProperty { get; set; }
        public string RecipePeople { get; set; }
        public string RecipePeopleMail { get; set; }
        public string RecipeImage { get; set; }
    }
}
