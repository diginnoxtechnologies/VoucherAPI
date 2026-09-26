
using Microsoft.AspNetCore.Identity;
using VoucherPortal.Data.Models;

namespace VoucherPortal.Service.Models.Authentication.User
{
    public class LoginOtpResponse
    {
        public string Token { get; set; } = null!;
        public bool IsTwoFactorEnable { get; set; } 
        public ApplicationUser User { get; set; } = null!;
    }
}
