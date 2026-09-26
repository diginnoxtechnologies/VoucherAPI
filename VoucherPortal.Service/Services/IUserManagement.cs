using Microsoft.AspNetCore.Identity;
using VoucherPortal.Data.Models;
using VoucherPortal.Service.Models;
using VoucherPortal.Service.Models.Authentication.Login;
using VoucherPortal.Service.Models.Authentication.SignUp;
using VoucherPortal.Service.Models.Authentication.User;

namespace VoucherPortal.Service.Services
{
    public interface IUserManagement
    { 
        
        /// <summary>
       /// Brief description of what the method does.
       /// </summary>
       /// <param name="registerUser">Description of the parameter.</param>
       /// <returns>Description of the return value.</returns>

        Task<ApiResponse<CreateUserResponse>> CreateUserWithTokenAsync(RegisterUser registerUser);
        Task<ApiResponse<List<string>>> AssignRoleToUserAsync(List<string> roles, ApplicationUser user);
        Task<ApiResponse<LoginOtpResponse>> GetOtpByLoginAsync(LoginModel loginModel);
        Task<ApiResponse<LoginResponse>> GetJwtTokenAsync(ApplicationUser user);
        Task<ApiResponse<LoginResponse>> LoginUserWithJWTokenAsync(string otp, string userName);
        Task<ApiResponse<LoginResponse>> RenewAccessTokenAsync(LoginResponse tokens);





    }
}
