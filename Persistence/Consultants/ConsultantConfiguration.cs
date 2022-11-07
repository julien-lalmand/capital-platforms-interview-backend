using CapitalPlatforms.Domain.Consultants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapitalPlatforms.Persistence.Consultants
{
    public class ConsultantConfiguration : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> builder)
        {
            builder.ToTable("ConsultantInfo");

            builder.HasKey(c => c.Id)
                .HasName("ConsultantInfoId");

            builder.Property(c => c.Id)
                .HasColumnName("ConsultantInfoId");
        }
    }
}
