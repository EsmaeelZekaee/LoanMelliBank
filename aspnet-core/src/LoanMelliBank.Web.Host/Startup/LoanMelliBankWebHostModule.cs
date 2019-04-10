using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LoanMelliBank.Configuration;

namespace LoanMelliBank.Web.Host.Startup
{
    [DependsOn(
       typeof(LoanMelliBankWebCoreModule))]
    public class LoanMelliBankWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LoanMelliBankWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LoanMelliBankWebHostModule).GetAssembly());
        }
    }
}
