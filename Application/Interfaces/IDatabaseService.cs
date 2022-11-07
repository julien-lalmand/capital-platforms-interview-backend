using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;
using CapitalPlatforms.Domain.DiscretionaryRules;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlatforms.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Consultant> Consultants { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<DiscretionaryRule> DiscretionaryRules { get; set; }

        void Save();
    }
}
