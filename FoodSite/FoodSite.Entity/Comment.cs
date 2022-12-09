using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public string CommentMail { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentApproved { get; set; }
        public string CommentDetails { get; set; }
        public List<FoodComment> FoodComments { get; set; }
    }
}
