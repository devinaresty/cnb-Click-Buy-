using ClickBuy.Application.Interfaces;
using ClickBuy.Domain.Entities;
using ClickBuy.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ClickBuy.Infrastructure.Repositories;

// Class ini mengimplementasikan (:) interface IProductRepository
public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    // Dependency Injection: Meminta ApplicationDbContext saat class ini dibuat
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        // Sama seperti prisma.product.findMany()
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        // Sama seperti prisma.product.findUnique()
        return await _context.Products.FindAsync(id);
    }

    public async Task AddAsync(Product product)
    {
        // Menambahkan ke tracking EF Core, belum masuk ke database
        await _context.Products.AddAsync(product);
        // Meyimpan perubahan ke SQL Server (mirip transaction commit)
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}