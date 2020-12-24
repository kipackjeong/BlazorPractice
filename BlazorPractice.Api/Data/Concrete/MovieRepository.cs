using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;

namespace BlazorPractice.Api.Data.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }


        public AllMoviesDto GetAllMovie()
        {
            var movieIndex = new AllMoviesDto();
            var todayDate = DateTime.UtcNow;
            movieIndex.InTheatersMovies = _context.Movies.Where(m => m.InTheater).OrderBy(m => m.ReleaseDate).ToList();
            movieIndex.UpcomingMovies = _context.Movies.Where(m => m.ReleaseDate > todayDate).ToList();
            movieIndex.OldMovies = _context.Movies.Where(m => !m.InTheater && m.ReleaseDate < todayDate).ToList();

            return movieIndex;
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == id);
        }


        public IEnumerable<Movie> GetAllMovieByName(string movieName)
        {
            return _context.Movies.Where(m => movieName != null && m.Title.ToLower().Contains(movieName.ToLower())).Take(10);
        }

        public void CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
