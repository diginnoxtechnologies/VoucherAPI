using Microsoft.AspNetCore.Identity;
using VoucherPortal.Data.Models;


namespace VoucherPortal.Service.Models.Authentication.User
{
    public class CreateUserResponse
    {
        public string Token { get; set; }=null!;
        public ApplicationUser User { get; set; } = null!;

    }
   

}
