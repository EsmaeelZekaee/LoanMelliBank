using System.Threading.Tasks;
using Abp.Application.Services;
using LoanMelliBank.Authorization.Accounts.Dto;

namespace LoanMelliBank.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
