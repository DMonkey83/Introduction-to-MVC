﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Data.Entity;
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
  }
}