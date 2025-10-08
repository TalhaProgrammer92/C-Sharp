
using CodeFirstApproach.Models;
using CodeFirstApproach.Services;
using CodeFirstApproach.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
//using CodeFirstApproach.Services;

namespace CodeFirstApproach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Injecting the (Car Entity) DbContext with SQL Server
            builder.Services.AddDbContext<CarContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddDbContext<CustomerContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // Register Services & Interfaces for Dependency Injection
            builder.Services.AddScoped<ICarService, CarService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
