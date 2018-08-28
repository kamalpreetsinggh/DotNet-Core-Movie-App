using MovieSearch.Models.Movie;
using System.Collections.Generic;
using System.Linq;

namespace MovieSearch.Data
{
    public class MovieData
    {
        public static List<MovieModel> movieList = new List<MovieModel>();

        public static void CreateMovie(int movieId, string movieName, string releaseYear, string genre)
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

        public static List<MovieModel> GetMovieList()
        {
            CreateMovie(1, "The Pursuit Of Happyness", "Biography", "2006");
            CreateMovie(2, "The Shawshank Redemption", "Drama", "1994");
            CreateMovie(3, "Inception", "Science Fiction", "2010");
            CreateMovie(4, "Intersteller", "Science Fiction", "2014");
            CreateMovie(5, "The Dark Knight", "Action", "2008");
            CreateMovie(6, "The Wolf Of Wall Street", "Drama", "2013");
            CreateMovie(7, "Logan", "Action", "2017");
            CreateMovie(8, "The Prestige", "Science Fiction", "2006");

            return movieList;
        }

        public MovieModel GetMovieById(int id)
        {
            return GetMovieList().Where(x => x.MovieId == id)?.FirstOrDefault();
        }
    }
}
