using CapitalPlatforms.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapitalPlatforms.Persistence.Customers
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CustomerInfo");

            builder.HasKey(c => c.Id)
                .HasName("CustomerId");

            builder.Property(c => c.Id)
                .HasColumnName("CustomerId");

        }
    }
}
