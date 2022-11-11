using System.ComponentModel.DataAnnotations;

namespace MiniShop.Web.Models
{
    public class PasswordModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        //[DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string RePassword { get; set; }
    }
}
