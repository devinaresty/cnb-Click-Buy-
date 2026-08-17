using clicbuy.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace clickbuy.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions Options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}