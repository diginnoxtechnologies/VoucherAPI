using System.ComponentModel.DataAnnotations;

namespace VoucherPortal.Service.Models.Authentication.Login
{
    public class LoginWithOTP
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }=null!;

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; } = null!;
    }
}
