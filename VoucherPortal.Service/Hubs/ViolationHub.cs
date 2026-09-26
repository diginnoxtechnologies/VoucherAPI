
using VoucherPortal.Service.Models.ViolationDTOs;
using Microsoft.AspNetCore.SignalR;


namespace VoucherPortal.Service.Hubs
{
    public class ViolationHub:Hub
    {
        public async Task SendViolation(ViolationDtoResponse violation)
        {
            await Clients.All.SendAsync("ReceiveViolation", violation);
        }

    }
}
