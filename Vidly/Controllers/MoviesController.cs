﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    private ApplicationDbContext _context;

    public MoviesController()
    {
      _context = new ApplicationDbContext();
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }

    // GET: Movies
    public ActionResult Index()
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();
      return View(movies);
    }

    public ActionResult Details(int id)
    {
      var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(mov => mov.Id == id);

      if (movie == null)
      {
        return HttpNotFound();
      }

      return View(movie);
    }

    [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
    public ActionResult ByReleseDate(int year, int month)
    {
      return Content(year + "/" + month);
    }

    public ActionResult New()
    {
      var genres = _context.Genres.ToList();
      var viewModel = new MovieFormViewModel()
      {
        Movie = new Movie(),
        Genres = genres
      };
      return View("MovieForm", viewModel);
    }

    [HttpPost]
    public ActionResult Save(Movie movie)
    {
      if (!ModelState.IsValid)
      {
        var viewModel = new MovieFormViewModel
        {
          Movie = movie,
          Genres = _context.Genres.ToList()
        };
        return View("MovieForm", viewModel);
      }
      if (movie.Id == 0)
      {
        _context.Movies.Add(movie);
      }
      else
      {
        var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

        movieInDb.Name = movie.Name;
        movieInDb.ReleaseDate = movie.ReleaseDate;
        movieInDb.GenreId = movie.GenreId;
        movieInDb.NumberInStock = movie.NumberInStock;

      }
        _context.SaveChanges();
      return RedirectToAction("Index", "Movies");
    }

    public ActionResult Edit(int id)
    {
      var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

      if (movie == null)
        return HttpNotFound();

      var viewModel = new MovieFormViewModel
      {
        Movie = movie,
        Genres = _context.Genres.ToList()
      };

      return View("MovieForm", viewModel);
    }
  }
}