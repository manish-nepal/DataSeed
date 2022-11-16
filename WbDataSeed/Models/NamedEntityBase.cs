using System.ComponentModel.DataAnnotations;

namespace WbDataSeed.Models;

public class NamedEntityBase : EntityBase
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }
}