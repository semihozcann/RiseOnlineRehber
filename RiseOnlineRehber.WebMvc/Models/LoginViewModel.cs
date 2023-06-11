using System.ComponentModel.DataAnnotations;

namespace RiseOnlineRehber.WebMvc.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

    }
}
