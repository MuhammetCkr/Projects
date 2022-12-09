using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class FoodComment
    {
        public int FoodId { get; set; }
        public int CommentId { get; set; }
        public Food Food { get; set; }
        public Comment Comment { get; set; }
    }
}
