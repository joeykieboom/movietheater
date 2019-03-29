using dotnet_core_theater.Classes;
using dotnet_core_theater.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using dotnet_core_theater.Data;
using System;
using Microsoft.AspNetCore.Authorization;

namespace dotnet_core_theater.Controllers
{
    public class QuickAccessHomeController : Controller
    {
        [Authorize(Roles = "QuickAccess")]
        public ActionResult Overview()
        {
            ApplicationDbContext db = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
    //        var Movies = TmdbApi.Instance.GetNowInTheater();
            var _movies = db.Schedules.Where(m => m.Starttime.Date == DateTime.Today).ToList();
          //  var _movies = TmdbApi.Instance.GetNowInTheater().Results;
            List<MovieModel> movies = new List<MovieModel>();
            foreach (var movie in _movies)
            {
                //movies.Add(movie);
                if (!movies.Where(m =>m.TMDBID == movie.MovieID).Any())
                {
                    movies.Add(MovieModel.GetModelByID(movie.MovieID));
                }
            }
            return View("QuickAccessOverview", movies);
        }

        [Authorize(Roles = "QuickAccess")]
        public ActionResult Index()
        {
            return View("QuickAccessIndex");
        }
    }
}
