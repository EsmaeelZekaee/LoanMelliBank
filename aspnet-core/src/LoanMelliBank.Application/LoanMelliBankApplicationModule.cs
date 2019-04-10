using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LoanMelliBank.Authorization;

namespace LoanMelliBank
{
    [DependsOn(
        typeof(LoanMelliBankCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LoanMelliBankApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LoanMelliBankAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LoanMelliBankApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
