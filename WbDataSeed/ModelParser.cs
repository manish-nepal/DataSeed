using System.Text.Json;
using CarSansar.Api.Models.Entities.Vehicle;
using WbDataSeed.Models.Enums;
using WbDataSeed.Models.Vehicle;

namespace WbDataSeed;

public static class ModelParser
{
    public static Dictionary<string, List<Model>> ReadModels()
    {
        using var reader = new StreamReader("./Models.csv");
        var brands = new List<Brand>();

        var brandMap = new Dictionary<string, List<Model>>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(',');
                var bodyType = values[2];
                var bodyTypeId = (BodyType)Enum.Parse(typeof(BodyType), bodyType);
                var vehicleType = values[4];
                var vehicleTypeId = (VehicleType)Enum.Parse(typeof(VehicleType), vehicleType);
                
                
                var model = new Model
                {
                    Name = values[3],
                    VehicleTypeId = vehicleTypeId,
                    BodyTypeId = bodyTypeId
                };

                if (brandMap.ContainsKey(values[1]))
                {
                    brandMap[values[1]].Add(model);
                }
                else
                {
                    var models = new List<Model>();
                    models.Add(model);
                    brandMap.Add(values[1], models);
                }
        }

        if (brandMap.Any())
        {
            foreach (var brandName in brandMap)
            {
                var brand = new Brand
                {
                    Name = brandName.Key
                };
                brands.Add(brand);
            }
        }

        return brandMap;
    }
}