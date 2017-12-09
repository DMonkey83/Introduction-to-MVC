using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    // GET: Movies
    public ActionResult Index()
    {
      var movie = new List<Movie>()
      {
        new Movie(){Name = "Thor"},
        new Movie(){Name = "Iron Man"}
      };
      return View(movie);
    }
    public ActionResult Random()
    {
      var movie = new Movie() { Name = "Ragnarok" };
      var customers = new List<Customer>
      {
        new Customer(){Name = "Einars"},
        new Customer(){Name = "Edite"}
      };
      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = customers
      };

      return View(viewModel);
      //return Content("Hello");
      //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

    }

    [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
    public ActionResult ByReleseDate(int year, int month)
    {
      return Content(year + "/" + month);
    }
  }
}