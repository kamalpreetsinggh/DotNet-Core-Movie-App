using MovieSearch.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearch.Data
{
    public class MovieData
    {
        public List<MovieModel> movieList = new List<MovieModel>();

        public void CreateMovie(int movieId, string movieName, string releaseYear, string genre)
        {
            MovieModel movie = new MovieModel
            {
                MovieId = movieId,
                MovieName = movieName,
                ReleaseYear = releaseYear,
                Genre = genre
            };

            movieList.Add(movie);
        }

        public List<MovieModel> GetMovieList()
        {
            CreateMovie(1, "The Pursuit Of Happyness", "Football", "2006");
            CreateMovie(2, "The Shawshank Redemption", "Football", "1994");
            CreateMovie(3, "Inception", "Tennis", "2010");
            CreateMovie(4, "Intersteller", "Tennis", "2014");
            CreateMovie(5, "The Dark Knight", "Cricket", "2008");
            CreateMovie(6, "The Wolf Of Wall Street", "Cricket", "2013");
            CreateMovie(7, "Logan", "Hockey", "2017");
            CreateMovie(8, "The Prestige", "Swimming", "2006");

            return movieList;
        }

        public MovieModel GetMovieById(int id)
        {
            return GetMovieList().Where(x => x.MovieId == id)?.FirstOrDefault();
        }
    }
}
