using Abp.AspNetCore.Mvc.ViewComponents;

namespace LoanMelliBank.Web.Views
{
    public abstract class LoanMelliBankViewComponent : AbpViewComponent
    {
        protected LoanMelliBankViewComponent()
        {
            LocalizationSourceName = LoanMelliBankConsts.LocalizationSourceName;
        }
    }
}
