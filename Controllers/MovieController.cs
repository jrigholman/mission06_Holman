using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission06_Holman.Models;
using System.Linq;

namespace Mission06_Holman.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        // GET: /Movie/
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        // GET: /Movie/AddMovie
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // POST: /Movie/AddMovie
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: /Movie/Edit/{id}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

         

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                // Log model state errors for debugging
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return View(movie);
            }

            try
            {
                var existingMovie = _context.Movies.Find(movie.MovieId);
                if (existingMovie != null)
                {
                    existingMovie.Title = movie.Title;
                    existingMovie.Year = movie.Year;
                    existingMovie.Director = movie.Director;
                    existingMovie.Rating = movie.Rating;
                    existingMovie.Edited = movie.Edited;
                    existingMovie.CategoryId = movie.CategoryId;

                    _context.Entry(existingMovie).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Movies.Any(m => m.MovieId == movie.MovieId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }



        // GET: /Movie/Delete/{id}
        [HttpGet]
        public IActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: /Movie/Delete/{id}
        [HttpPost, ActionName("DeleteMovie")]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
