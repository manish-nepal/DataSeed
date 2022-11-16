using CarSansar.Api.Models.Entities.Vehicle;
using WbDataSeed.Models.Enums;

namespace WbDataSeed.Models.Vehicle;

public class Model : NamedEntityBase
{
    public Guid BrandId { get; set; }
    public virtual Brand Brand { get; set; }
    public BodyType BodyTypeId { get; set; }
    public VehicleType VehicleTypeId { get; set; }
}