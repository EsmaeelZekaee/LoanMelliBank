using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace LoanMelliBank.Web.Views
{
    public abstract class LoanMelliBankRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LoanMelliBankRazorPage()
        {
            LocalizationSourceName = LoanMelliBankConsts.LocalizationSourceName;
        }
    }
}
