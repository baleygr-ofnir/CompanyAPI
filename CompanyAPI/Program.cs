using CompanyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            builder.Services.AddDbContext<CompaniesContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString(
                "DefaultConnection"
                )
            ));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();
            
            // Routes
            app.MapGet("/companies", async (CompaniesContext db) =>
            {
                return await db.Companies.ToListAsync();
            });

            app.Run();  
        }
    }
}
