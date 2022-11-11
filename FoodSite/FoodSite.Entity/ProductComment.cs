using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class ProductComment
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
