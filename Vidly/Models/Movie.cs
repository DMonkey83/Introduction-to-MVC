using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
  public class Movie
  {
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [DisplayName("Release Date")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ReleaseDate { get; set; }

    [DisplayName("Date Added")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? DateAddedToTheStock { get; set; }

    [DisplayName("Number in Stock")]
    public int NumberInStock { get; set; }
    public Genre Genre { get; set; }
    [Required]
    [DisplayName("Genres")]
    public int GenreId { get; set; }
  }

  // /movies/random
}