
using Microsoft.EntityFrameworkCore;

namespace RepositoryPatternTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Configure Entity Framework Core to use a SQL Server database
            builder.Services.AddDbContext<Data.ProductContext>(options =>
                // Configure the database context to use SQL Server
                options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseSettings") ??
                
                // If the connection string is not found, throw an exception
                throw new InvalidOperationException("Connection string not found!")));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<Repository.IProductService, Repository.ProductService>();

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
