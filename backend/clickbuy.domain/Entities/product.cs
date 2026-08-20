using System.ComponentModel.DataAnnotations.Schema;

namespace clickbuy.Domain.Entities; ///alamat biar si product tau hrs import kemana

public class Product ///access modifier (wajib ada biar classnya kebaca)
{
    public Guid Id { get; set;} ///mirip uuid lagi lh klo diprisma
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; } ///uang atau financial wajib mnggunakan decimal
    public enum Category { VirtualNumber, DigitalSubscription, GameTopUp, Other} 
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; /// sama dengan "" agar tidak bernilai null
}