using BlazorPracticeServer.Entity;
using System.Collections.Generic;

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
