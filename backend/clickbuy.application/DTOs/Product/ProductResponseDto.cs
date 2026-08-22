namespace clickbuy.Application.DTOs.Product;

public class ProductResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    // Perhatikan: Kita mengubah Enum menjadi string agar frontend lebih mudah membacanya
    public string Category { get; set; } = string.Empty;
    public int Stock { get; set; }
}