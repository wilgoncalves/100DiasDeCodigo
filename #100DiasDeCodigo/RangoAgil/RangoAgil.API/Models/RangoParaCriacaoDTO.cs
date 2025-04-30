using System.ComponentModel.DataAnnotations;

namespace RangoAgil.API.Models;

public class RangoParaCriacaoDTO
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public required string Name { get; set; }
}

