using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Data.Concrete
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext _context;

        public GenreRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Genre> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenreById(int id)
        {
            return _context.Genres.FirstOrDefault(g => g.Id == id);
        }

        public void CreateGenre(Genre genre)
        {
            _context.Add(genre);
        }

        public void UpdateGenre(Genre genre)
        {

        }

        public void DeleteGenre(Genre genre)
        {
            _context.Remove(genre);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
