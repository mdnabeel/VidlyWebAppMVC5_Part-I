using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;
using VidlyWebApp.ViewModel;

namespace VidlyWebApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);

        }




        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(d => d.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        private IEnumerable<Movies>GetMovies()
        {
            return new List<Movies>
            {
                new Movies{Id=1, MovieName="Shrek"},
                new Movies{Id=2, MovieName="Money Heist"},
                new Movies{Id=3, MovieName="Shawshank Redemption"},
                new Movies{Id=4, MovieName="Mr Robot"},
                new Movies{Id=5, MovieName="Silicon Valley"},
                new Movies{Id=6, MovieName="The Social Network"},
                new Movies{Id=7, MovieName="The Accountant"}
            };
        }


    }
}