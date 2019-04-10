using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LoanMelliBank.Localization
{
    public static class LoanMelliBankLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LoanMelliBankConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LoanMelliBankLocalizationConfigurer).GetAssembly(),
                        "LoanMelliBank.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
