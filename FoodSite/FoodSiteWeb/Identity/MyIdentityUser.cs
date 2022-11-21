using Microsoft.AspNetCore.Identity;

namespace FoodSiteWeb.Identity
{
    public class MyIdentityUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<MyIdentityAddress> MyIdentityAddresses { get; set; }
    }
}
