using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LoanMelliBank.Configuration;

namespace LoanMelliBank.Web.Startup
{
    [DependsOn(typeof(LoanMelliBankWebCoreModule))]
    public class LoanMelliBankWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LoanMelliBankWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<LoanMelliBankNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LoanMelliBankWebMvcModule).GetAssembly());
        }
    }
}
