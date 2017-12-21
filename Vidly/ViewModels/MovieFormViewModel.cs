using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
  public class MovieFormViewModel
  {
    public IEnumerable<Genre> Genres { get; set; }
    public int? Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [DisplayName("Release Date")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime? ReleaseDate { get; set; }


    [DisplayName("Number in Stock")]
    [Required]
    [Range(1, 20, ErrorMessage = "Rhe field Number in Stock must be between 1 and 20")]
    public int? NumberInStock { get; set; }
    [Required]
    [DisplayName("Genres")]
    public int? GenreId { get; set; }

    public string Title
    {
      get
      {
        return Id != 0 ? "Edit Movie" : "New Movie";
      }
    }

    public string Button
    {
      get {
        return Id != 0 ? "Update" : "Save";
      }
    }

    public MovieFormViewModel()
    {
      Id = 0;
    }

    public MovieFormViewModel(Movie movie)
    {
      Id = movie.Id;
      Name = movie.Name;
      ReleaseDate = movie.ReleaseDate;
      NumberInStock = movie.NumberInStock;
      GenreId = movie.GenreId;
    }
  }
}