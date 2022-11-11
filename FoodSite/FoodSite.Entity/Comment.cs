using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Comment : BaseEntity
    {
        public string CommentContent { get; set; }
        public List<ProductComment> ProductComments { get; set; }
    }
}
