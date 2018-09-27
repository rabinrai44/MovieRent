using MovieRent.Models;
using MovieRent.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MovieRent.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

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
            var movies = _context.Movies.Include("Genre").ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include("Genre").FirstOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();
                        
            return View(movie);
        }

        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}