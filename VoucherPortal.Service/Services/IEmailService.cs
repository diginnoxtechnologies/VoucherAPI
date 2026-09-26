

using VoucherPortal.Service.Models;

namespace VoucherPortal.Service.Services
{
    public interface IEmailService
    {
        string SendEmail(Message message);
    }
}
