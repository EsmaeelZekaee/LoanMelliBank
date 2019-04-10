using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LoanMelliBank.MultiTenancy.Dto;

namespace LoanMelliBank.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

