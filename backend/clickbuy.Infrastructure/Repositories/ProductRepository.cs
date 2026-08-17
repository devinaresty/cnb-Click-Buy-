using clickbuy.Application.Interface;
using clickbuy.Domain.Entities;
using clickbuy.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace clickbuy.Infrastructure.Repositories;

// Class ini mengimplementasikan (:) interface IProductRepository
public class ProductRepository : IProductRepository
{
    private readonly ApiContext _context;

    // Dependency Injection: Meminta ApiContext saat class ini dibuat
    public ProductRepository(ApiContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
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