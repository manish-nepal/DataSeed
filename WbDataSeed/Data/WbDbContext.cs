using CarSansar.Api.Models.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using WbDataSeed.Models.Vehicle;

namespace WbDataSeed.Data;

public class WbDbContext : DbContext
{
    public WbDbContext(string connectionString) 
        : base(new DbContextOptionsBuilder<WbDbContext>().UseNpgsql(connectionString)
            .UseSnakeCaseNamingConvention()
            .Options)
    {
    }
    
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Model> Models { get; set; }
}