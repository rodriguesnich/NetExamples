using Microsoft.EntityFrameworkCore;
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Data;

public class CheckoutDbContext : DbContext
{
    public CheckoutDbContext(DbContextOptions<CheckoutDbContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(o => o.OrderProducts)
            .WithOne(i => i.Order)
            .HasForeignKey(i => i.OrderId);
            
        modelBuilder.Entity<OrderProduct>()
            .Property(i => i.UnitPrice)
            .HasPrecision(18, 2);
            
        modelBuilder.Entity<Order>()
            .Property(o => o.TotalAmount)
            .HasPrecision(18, 2);
    }
}
