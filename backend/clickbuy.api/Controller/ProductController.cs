using clickbuy.Application.Interface;
using clickbuy.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace clickbuy.api.Controllers;

// Atribut ini menandakan bahwa class ini adalah API, dan akan memvalidasi input otomatis
[ApiController]
// [controller] akan otomatis diganti menjadi "products" berdasarkan nama class ProductsController
[Route("api/[controller]")] 
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repository;

    // Dependency Injection: API meminta IProductRepository
    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }

    // Endpoint: GET /api/products
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _repository.GetAllAsync();
        return Ok(products); // Mengembalikan status 200 OK beserta datanya
    }

    // Endpoint: GET /api/products/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        
        if (product == null)
        {
            return NotFound(new { message = "Produk tidak ditemukan" }); // Status 404
        }
        
        return Ok(product);
    }
}