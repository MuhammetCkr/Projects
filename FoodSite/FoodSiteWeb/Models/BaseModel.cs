namespace FoodSiteWeb.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
    }
}
