using System.ComponentModel.DataAnnotations;

namespace KUSYS_Demo.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı Adınız Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Parola Giriniz")]
        public string Password { get; set; }
    }
}
