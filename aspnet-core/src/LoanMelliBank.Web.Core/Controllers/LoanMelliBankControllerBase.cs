using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LoanMelliBank.Controllers
{
    public abstract class LoanMelliBankControllerBase: AbpController
    {
        protected LoanMelliBankControllerBase()
        {
            LocalizationSourceName = LoanMelliBankConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
