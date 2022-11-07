using CapitalPlatforms.Application.Interfaces;
using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;
using CapitalPlatforms.Domain.DiscretionaryRules;
using CapitalPlatforms.Persistence.Consultants;
using CapitalPlatforms.Persistence.Customers;
using CapitalPlatforms.Persistence.DiscretionaryRules;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CapitalPlatforms.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        private readonly IConfiguration _configuration;

        public DatabaseService(IConfiguration configuration)
        {
            _configuration = configuration;
            Database.EnsureCreated();
        }

        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DiscretionaryRule> DiscretionaryRules { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("CapitalPlatforms");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ConsultantConfiguration().Configure(modelBuilder.Entity<Consultant>());
            new CustomerConfiguration().Configure(modelBuilder.Entity<Customer>());
            new DiscretionaryRuleConfiguration().Configure(modelBuilder.Entity<DiscretionaryRule>());
        }

    }
}
