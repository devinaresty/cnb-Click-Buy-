using clickbuy.Domain.Entities; //sm kyk ngeimport di ts

namespace clickbuy.Application.Interface;

public interface IProductRepository ///wajib menggunakan kpital (interface adalah kontrak)
{
    Task<Product?> GetByIdAsync(Guid id );
    Task<IEnumerable<Product>> GetAllAsync();
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Guid id);
}