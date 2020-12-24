using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Services
{
    public interface IGenreService
    {
        ValueTask<IEnumerable<Genre>> RetrieveAllGenreAsync();
        ValueTask<Genre> RetrieveGenreByIdAsync(int id);
        ValueTask<Genre> RegisterGenreAsync(Genre genre);
        ValueTask<Genre> UpdateGenreAsync(Genre genre, int id);
        ValueTask<Genre> DeleteGenreAsync(int id);
    }
}
