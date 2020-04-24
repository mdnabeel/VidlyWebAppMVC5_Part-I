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
        public ActionResult Random()
        {
            var movie = new Movies() { MovieName = "Money Heist" };
            var customer = new List<Customers>
            {
                new Customers {CustomerName = "Customer1" },
                new Customers {CustomerName = "Customer2" },
                new Customers {CustomerName = "Customer3" },
                new Customers {CustomerName = "Customer4" },
                
            };

            var viewmodel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customer = customer

            };

            return View(viewmodel);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }



        public ActionResult Edit(int Id)
        {

            return Content("Id=" + Id);
        }



        public ActionResult Index(int? PageIndex, string SortBy)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;

            if (String.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";

            return Content(string.Format("PageIndex={0}, SortBy= {1}", PageIndex, SortBy));
        }




        //[Route("movies/release/{year}/{month}")]
        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year +"/" +month);
        }




        




    }
}