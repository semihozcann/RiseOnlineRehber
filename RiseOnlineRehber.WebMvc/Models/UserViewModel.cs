using System.ComponentModel.DataAnnotations;
using System;

namespace RiseOnlineRehber.WebMvc.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "E posta adresini yazınız")]
        public string Email { get; set; }

        [Required(ErrorMessage = "İsminizi yazınız")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisminizi yazınız")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Şifrenizi Yazınız")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifreler aynı olmalıdır")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Telefon numaranızı yazınız")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Ülkenizi yazınız")]
        public string County { get; set; }

        [Required(ErrorMessage = "Doğum tarihini yazınız")]
        public DateTime DateofBirth { get; set; }


    }
}
