using CapitalPlatforms.Domain.DiscretionaryRules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapitalPlatforms.Persistence.DiscretionaryRules
{
    public class DiscretionaryRuleConfiguration : IEntityTypeConfiguration<DiscretionaryRule>
    {
        public void Configure(EntityTypeBuilder<DiscretionaryRule> builder)
        {
            builder.ToTable("DiscretionaryRules");

            builder.HasKey(x => x.Id)
                .HasName("DiscretionaryRuleID");

            builder.Property(x => x.Id)
                .HasColumnName("DiscretionaryRuleID");
        }
    }
}
