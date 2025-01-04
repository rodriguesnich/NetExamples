using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(op => op.Id);

            builder.Property(op => op.ProductId)
                .IsRequired();

            builder.Property(op => op.Quantity)
                .IsRequired();

            builder.Property(op => op.UnitPrice)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}
