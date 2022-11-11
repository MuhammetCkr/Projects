using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public decimal Point { get; set; }
        public string Mail { get; set; }
    }
}
