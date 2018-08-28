using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieSearch.Data;
using MovieSearch.Models.Movie;

namespace MovieSearch.Controllers
{
    public class MovieController : Controller
    {
        public static List<MovieModel> movieList = MovieData.GetMovieList();

        public IActionResult Index()
        {
            return View(movieList);
        }

        public IActionResult SearchById(int id)
        {
            MovieData movieData = new MovieData();
            var movie = movieData.GetMovieById(id);

            if (movie != null)
            {
                return PartialView("_MoviePartial", movie);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(MovieModel movie)
        {
            movieList.Add(new MovieModel
            {
                MovieId = movie.MovieId,
                MovieName = movie.MovieName,
                ReleaseYear = movie.ReleaseYear,
                Genre = movie.Genre
            });

            return RedirectToAction("Index", "Movie");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(MovieModel movie)
        {
            bool isFound = false;

            foreach (var savedMovie in movieList)
            {
                if (movie.MovieId == savedMovie.MovieId)
                {
                    isFound = true;
                    savedMovie.MovieName = movie.MovieName;
                    savedMovie.ReleaseYear = movie.ReleaseYear;
                    savedMovie.Genre = movie.Genre;
                    break;
                }
            }

            if (isFound)
            {
                return RedirectToAction("Index", "Movie");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(MovieModel movie)
        {
            bool isFound = false;

            foreach (var savedMovie in movieList)
            {
                if (savedMovie.MovieId == movie.MovieId)
                {
                    isFound = true;
                    movieList.Remove(savedMovie);
                    break;
                }
            }

            if (isFound)
            {
                return RedirectToAction("Index", "Movie");
            }
            else
            {
                return NotFound();
            }
        }
    }
}