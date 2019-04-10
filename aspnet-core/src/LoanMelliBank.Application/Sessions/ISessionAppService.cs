using System.Threading.Tasks;
using Abp.Application.Services;
using LoanMelliBank.Sessions.Dto;

namespace LoanMelliBank.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
