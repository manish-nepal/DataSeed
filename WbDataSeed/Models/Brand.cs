using System.ComponentModel.DataAnnotations;
using WbDataSeed.Models;
using WbDataSeed.Models.Vehicle;

namespace CarSansar.Api.Models.Entities.Vehicle;

public class Brand : NamedEntityBase
{
	[StringLength(1024)]
	public string Logo { get; set; }
	public virtual IList<Model> Models { get; set; }
}