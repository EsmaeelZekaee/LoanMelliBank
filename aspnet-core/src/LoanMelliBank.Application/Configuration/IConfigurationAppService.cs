using System.Threading.Tasks;
using LoanMelliBank.Configuration.Dto;

namespace LoanMelliBank.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
