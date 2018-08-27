using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieSearch.Data;
using MovieSearch.Models.Movie;

namespace MovieSearch.Controllers
{
    public class MovieController : Controller
    {
        List<MovieModel> movieList = new List<MovieModel>();

        public IActionResult Index()
        {
            MovieData movieData = new MovieData();
            movieList = movieData.GetMovieList();
            return View(movieList);
        }

        public IActionResult SearchById(int id)
        {
            MovieData movieData = new MovieData();
            var movie = movieData.GetMovieById(id);
            if(movie!=null)
            {
                return PartialView("_MovieByIdViewPartial", movie);
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
                ReleaseYear= movie.ReleaseYear,
                Genre = movie.Genre
            });

            return RedirectToAction("Index", "Movie");
        }

        [HttpPost]
        public IActionResult Update(MovieModel movie)
        {
            bool isFound = false;
            foreach (var savedMovie in movieList)
            {
                if (savedMovie.MovieId == savedMovie.MovieId)
                {
                    isFound = true;
                    savedMovie.MovieName = savedMovie.MovieName;
                    savedMovie.ReleaseYear = savedMovie.ReleaseYear;
                    savedMovie.Genre = savedMovie.Genre;
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

        [HttpPost]
        public IActionResult Delete(MovieModel movie)
        {
            bool isFound = false;
            MovieModel temp = new MovieModel();
            foreach (var savedMovie in movieList)
            {
                if (savedMovie.MovieId == movie.MovieId)
                {
                    isFound = true;
                    temp = savedMovie;
                }
            }
            if (isFound)
            {
                movieList.Remove(temp);
                return RedirectToAction("Index", "Movie");
            }
            else
            {
                return NotFound();
            }
        }
    }
}