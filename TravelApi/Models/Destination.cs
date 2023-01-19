using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models;

public class Destination
{
  public int DestinationId { get; set; }

  [Required]
  [StringLength(30)]
  public string Location { get; set; }

  [Required]
  [StringLength(30)]
  public string Country { get; set; }

  [StringLength(30)]
  public string State { get; set; }

  [Required]
  //[StringLength(300)]
  public string Review { get; set; }

  [Required]
  [Range(1, 5, ErrorMessage= "Rating must be between 1 and 5.")]
  public int Rating { get; set; } 
}
