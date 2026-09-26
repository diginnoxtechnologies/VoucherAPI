using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherPortal.Data.Models.Violations;
using VoucherPortal.Service.Models.ViolationDTOs;

namespace VoucherPortal.Service.Services
{
    public interface IViolationService
    {
        Task<ViolationDtoResponse> AddViolationAsync(ViolationDtoRequest violation);
        Task<List<ViolationDtoResponse>> GetAllViolationsAsync();
    }
}
