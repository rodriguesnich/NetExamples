using Microsoft.EntityFrameworkCore;
using MinimalCrudMvc.App.Models;

namespace MinimalCrudMvc.App.Data;

public class ApplicationDbContext : DbContext
{
 public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; } = default!;
    public DbSet<Premium> Premia { get; set; } = default!;
}
