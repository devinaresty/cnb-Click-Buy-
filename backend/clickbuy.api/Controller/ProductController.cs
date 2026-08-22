using clickbuy.Application.Interface;
using clickbuy.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace clickbuy.api.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _repository.GetAllAsync();
        return Ok(products); 
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        
        if (product == null)
        {
            return NotFound(new { message = "Produk tidak ditemukan" }); 
        }
        
        return Ok(product);
    }
}