using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LoanMelliBank.Configuration;
using LoanMelliBank.EntityFrameworkCore;
using LoanMelliBank.Migrator.DependencyInjection;

namespace LoanMelliBank.Migrator
{
    [DependsOn(typeof(LoanMelliBankEntityFrameworkModule))]
    public class LoanMelliBankMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public LoanMelliBankMigratorModule(LoanMelliBankEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(LoanMelliBankMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                LoanMelliBankConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LoanMelliBankMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
