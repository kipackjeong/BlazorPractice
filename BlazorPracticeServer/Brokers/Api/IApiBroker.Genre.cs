using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<Genre>> GetAllGenresAsync();
        ValueTask<Genre> GetGenreById(int id);
        ValueTask<Genre> PostGenreAsync(Genre movie);
        ValueTask<Genre> PutGenreAsync(Genre movie, int id);
        ValueTask<Genre> DeleteGenreAsync(int id);
    }
}
