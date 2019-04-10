using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LoanMelliBank.Authorization.Roles;
using LoanMelliBank.Authorization.Users;
using LoanMelliBank.MultiTenancy;
using LoanMelliBank.LoanInfo;
using System.Linq;

namespace LoanMelliBank.EntityFrameworkCore
{
    public class LoanMelliBankDbContext : AbpZeroDbContext<Tenant, Role, User, LoanMelliBankDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> People { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Guarantor> Guarantors { get; set; }
        public DbSet<AddressInfo> AddressInfos { get; set; }
        public DbSet<Account> Account { get; set; }
        public LoanMelliBankDbContext(DbContextOptions<LoanMelliBankDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Loan>().HasOne(x => x.Person).WithMany(x => x.Loans).IsRequired().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Guarantor>().HasOne(x => x.Person).WithMany(x => x.Guarantors).IsRequired().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Person>().HasMany(x => x.Loans);
            modelBuilder.Entity<Person>().HasMany(x => x.Guarantors);
            base.OnModelCreating(modelBuilder);
        }
    }
}
