using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        void CreateGenre(Genre genre);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        bool SaveChanges();
    }
}
