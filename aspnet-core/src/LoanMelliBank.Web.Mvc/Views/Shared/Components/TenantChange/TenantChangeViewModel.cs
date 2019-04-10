using Abp.AutoMapper;
using LoanMelliBank.Sessions.Dto;

namespace LoanMelliBank.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
