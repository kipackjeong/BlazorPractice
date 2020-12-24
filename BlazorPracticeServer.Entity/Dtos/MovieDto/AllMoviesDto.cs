using System.Collections.Generic;


namespace BlazorPracticeServer.Entity.Dtos.MovieDto
{
    public class AllMoviesDto
    {
        public List<Movie> UpcomingMovies { get; set; }
        public List<Movie> InTheatersMovies { get; set; }
        public List<Movie> OldMovies { get; set; }
    }
}
