//using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Product_Layered_Architecture.Data;
using Product_Layered_Architecture.Data.Repositories;
using Product_Layered_Architecture.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// Requires package: Swashbuckle.AspNetCore
builder.Services.AddSwaggerGen();

// Register Repositories & Services
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
