using System.ComponentModel.DataAnnotations;

namespace LibApp.WebUI.Areas.Identity.Pages.Account
{
    public partial class LoginModel
    {
        public class LoginInputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Do you remember me?")]
            public bool RememberMe { get; set; }
        }
    }
}
