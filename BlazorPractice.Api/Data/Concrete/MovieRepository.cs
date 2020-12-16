using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Data.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        private AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Movie> GetAllMovie()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == id);
        }

        public void CreateMovie(Movie movie)
        {
            _context.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Remove(movie);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
