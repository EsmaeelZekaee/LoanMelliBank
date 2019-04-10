using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LoanMelliBank.Configuration;
using LoanMelliBank.Web;

namespace LoanMelliBank.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LoanMelliBankDbContextFactory : IDesignTimeDbContextFactory<LoanMelliBankDbContext>
    {
        public LoanMelliBankDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LoanMelliBankDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LoanMelliBankDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LoanMelliBankConsts.ConnectionStringName));

            return new LoanMelliBankDbContext(builder.Options);
        }
    }
}
