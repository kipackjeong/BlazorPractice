using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Services
{
    public interface IGenreService
    {
        ValueTask<IEnumerable<Genre>> RetrieveAllGenreAsync();
        ValueTask<Genre> RetrieveGenreByIdAsync(int id);
        ValueTask<Genre> RegisterGenreAsync(Genre movie);
        ValueTask<Genre> UpdateGenreAsync(Genre movie, int id);
        ValueTask<Genre> DeleteGenreAsync(int id);
    }
}
