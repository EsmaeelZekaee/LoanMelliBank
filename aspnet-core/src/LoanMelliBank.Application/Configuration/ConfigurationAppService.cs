using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LoanMelliBank.Configuration.Dto;

namespace LoanMelliBank.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LoanMelliBankAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
