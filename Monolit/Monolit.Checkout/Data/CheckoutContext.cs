using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Data
{
    public class CheckoutContext : DbContext
    {
        public CheckoutContext(DbContextOptions<CheckoutContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CheckoutContext).Assembly);
        }
    }
}
using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Data
{
    public class CheckoutContext : DbContext
    {
        public CheckoutContext(DbContextOptions<CheckoutContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CheckoutContext).Assembly);
        }
    }
}
