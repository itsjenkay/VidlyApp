using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    { 
        private VidlyContext _context;

        public MoviesController()
        {
            _context = new VidlyContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
       
        public ActionResult Index()
        {
            var viewmodel = new RandomMovieViewModel
            {
                Movie = _context.movies.Include(c => c.Genre).ToList()
            };

            return View(viewmodel);

        }
        
        
        //Print out customer details in the form for editing 
        public ActionResult Details(int Id)
        {
            var movieDetails = _context.movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);

            if (movieDetails==null)
            {
                return HttpNotFound();
            }

            var viewModel = new MoviesViewModel
            {
                Movie = movieDetails,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }


      // Movie form for customers
        public ActionResult MovieForm()
        {
            var genres = _context.Genres.ToList();

            var viewmodel = new MoviesViewModel()
            {
                Genres = genres

            };
            return View(viewmodel);

        }

        //Action for adding new movie
        public ActionResult AddMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new MoviesViewModel()
                {
                   Movie=movie,
                   Genres=_context.Genres.ToList()
                };
            }
            if (movie.Id == 0)
                _context.movies.Add(movie);
            else
            {
                var moviesInDb = _context.movies.Single(c => c.Id == movie.Id);
                moviesInDb.Name = movie.Name;
                moviesInDb.NumbersInStock = movie.NumbersInStock;
                moviesInDb.ReleasedDate = movie.ReleasedDate;
                moviesInDb.DateAdded = movie.DateAdded;
                moviesInDb.GenreId = movie.GenreId;
            }

            _context.SaveChanges();
              
            return RedirectToAction("Index","Movies");
        }

      public ActionResult AddNewMovie()
      {
            var genre = _context.Genres.ToList();

            var viewmodel = new MoviesViewModel
            {
                Genres = genre
            };

           return View( viewmodel);

         
        }

    }
}