using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
  public class MovieDto
  {
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime? DateAddedToTheStock { get; set; }

    [Required]
    [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20")]
    public int NumberInStock { get; set; }

    [Required]
    public int GenreId { get; set; }

    public GenreDto Genre { get; set; }
  }
}
