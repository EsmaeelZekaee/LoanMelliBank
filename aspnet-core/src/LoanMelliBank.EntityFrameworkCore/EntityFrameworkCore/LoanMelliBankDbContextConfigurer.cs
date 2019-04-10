using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LoanMelliBank.EntityFrameworkCore
{
    public static class LoanMelliBankDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LoanMelliBankDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LoanMelliBankDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
