// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CarSansar.Api.Models.Entities.Vehicle;
using Microsoft.EntityFrameworkCore.Internal;
using WbDataSeed;
using WbDataSeed.Data;

var brands = ModelParser.ReadModels();
using var context = new WbDbContext("Server=localhost;Port=5432;Database=carsansar;User Id=postgres;Password=postgres;Include Error Detail=true");
var existing = context.Set<Brand>();
foreach (var brand in brands)
{
    existing.Add(new Brand
    {
        Name = brand.Key,
        Models = brand.Value
    });
}
context.SaveChanges();