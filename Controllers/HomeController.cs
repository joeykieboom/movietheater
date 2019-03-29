using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_core_theater.ViewModels;
using dotnet_core_theater.Data;
using dotnet_core_theater.Models;
using dotnet_core_theater.Classes;

namespace dotnet_core_theater.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());

            List<ScheduleModel> model = new List<ScheduleModel>();

            foreach (ScheduleModel schedule in db.Schedules.Where(i => i.Starttime.Date >= DateTime.Today).Where(i => i.Starttime.Date <= DateTime.Today.AddDays(7)).ToList())
            {
                if (!model.Where(m=>m.MovieID == schedule.MovieID).Any())
                {
                    model.Add(schedule);
                }
            }

            List<MovieModel> movies = new List<MovieModel>();

            foreach (var movie in TmdbApi.Instance.GetUpcoming().Results.Where(m=>m.ReleaseDate.Value.Date >= DateTime.Today))
            {
                if (!model.Where(x=>x.MovieID == movie.Id).Any())
                {
                    movies.Add(MovieModel.GetModelByID(movie.Id));
                }
            }

            HomeViewModel HVModel = new HomeViewModel() { Schedules = model, Movies = movies};

            return View(HVModel);
        }
    }
}