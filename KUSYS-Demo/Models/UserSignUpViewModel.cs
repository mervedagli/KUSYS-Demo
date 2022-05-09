using System.ComponentModel.DataAnnotations;

namespace KUSYS_Demo.Models
{
    public class UserSignUpViewModel
    {

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Parola Giriniz")]
        public string Password { get; set; }

        [Display(Name = "Parola Tekrarı")]
        [Compare("Password",ErrorMessage = "Parola Tekrarı Giriniz")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail Adresi Giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adınız Giriniz")]
        public string UserNamee { get; set; }
    }
}
