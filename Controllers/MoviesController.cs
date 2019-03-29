using dotnet_core_theater.Classes;
using dotnet_core_theater.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTheater.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Index(int id)
        {
            MovieModel movie = new MovieModel(TmdbApi.Instance.GetMovieByID(id));
            return View(movie);
        }
    }
}