using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoveLib.Models;
using MoveLib.ViewModels;

namespace MoveLib.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Batman" };

          var customers = new List<Customer>
            {
                new Customer { Name = "Joe" },
                new Customer { Name = "Ben" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("ID=" + id);

        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //[Route("movies/released/{year}/{month : regex(\\d{2}) : range(1,12) }")]
        //public ActionResult ByReleaseDate(int year, byte month) {
        //    return Content(year + "/" + month);
        //}

    }
}