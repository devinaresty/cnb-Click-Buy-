using clickbuy.Domain.Entities; 
using Microsoft.EntityFrameworkCore;

namespace clickbuy.Infrastructure.Data;

public class ApiContext : DbContext
{
    // C# mewajibkan tipe generik <ApiContext> di sini, dan huruf 'options' disamakan
    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}