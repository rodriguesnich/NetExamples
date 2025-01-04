using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Infrastructure.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("clients");
        
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Document).IsRequired();
        builder.Property(x => x.Street).IsRequired();
        builder.Property(x => x.Number).IsRequired();
        builder.Property(x => x.Complement).IsRequired();
        builder.Property(x => x.City).IsRequired();
        builder.Property(x => x.State).IsRequired();
        builder.Property(x => x.ZipCode).IsRequired();
        
        builder.HasOne(x => x.Order)
            .WithOne()
            .HasForeignKey<Client>(x => x.OrderId);
    }
}
