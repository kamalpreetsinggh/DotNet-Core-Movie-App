using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearch.Models.Movie
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string ReleaseYear { get; set; }
        public string Genre { get; set; }
    }
}
