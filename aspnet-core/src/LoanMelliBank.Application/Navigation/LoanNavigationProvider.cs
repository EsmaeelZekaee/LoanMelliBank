using Abp.Application.Navigation;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMelliBank.Application.Navigation
{
    public class LoanNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LoanMelliBankConsts.LocalizationSourceName);
        }
    }
}
