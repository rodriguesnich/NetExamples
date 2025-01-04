using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            
            builder.Property(o => o.CustomerId)
                .IsRequired();

            builder.Property(o => o.TotalAmount)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(o => o.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.HasOne(o => o.Client)
                .WithOne(c => c.Order)
                .HasForeignKey<Client>(c => c.OrderId);

            builder.HasMany(o => o.OrderProducts)
                .WithOne(op => op.Order)
                .HasForeignKey(op => op.OrderId);
        }
    }
}
