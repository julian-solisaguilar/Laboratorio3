using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
  public class MovieController : Controller
  {
    public IActionResult Index()
    {
      var movies = GetListOfMovies();
      ViewBag.MainTitle = "List of my favorite films";
      return View(movies);
    }

    private List<MovieModel> GetListOfMovies()
    {
      List<MovieModel> movies = new List<MovieModel>();
      movies.Add(new MovieModel { Id = 1, Name = "Dune", Genre = "Science Fiction", 
        ReleasedDate = new DateTime(2021, 10, 22) });
      movies.Add(new MovieModel { Id = 2, Name = "Spiderman: No Way Home", Genre = "Action/Adventure", 
        ReleasedDate = new DateTime(2021, 12, 17) });
      movies.Add(new MovieModel { Id = 3, Name = "Your Name", Genre = "Romance/Fantasy", 
        ReleasedDate = new DateTime(2016, 08, 26) });

      return movies;
    }
  }
}
