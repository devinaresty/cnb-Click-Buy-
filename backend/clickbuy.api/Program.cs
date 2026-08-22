using clickbuy.Application.Interface;
using clickbuy.Infrastructure.Data;
using clickbuy.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. DAFTARKAN DEPENDENCY INJECTION DI SINI
builder.Services.AddControllers();

builder.Services.AddDbContext<ApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Hanya mendaftarkan Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 2. BUILD APLIKASI
var app = builder.Build();

// 3. KONFIGURASI HTTP REQUEST PIPELINE (MIDDLEWARE)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); 

app.Run();