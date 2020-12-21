using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Services
{
    public interface IMovieService
    {
        ValueTask<IEnumerable<Movie>> RetrieveAllMovieAsync();
        ValueTask<Movie> RegisterMovieAsync(Movie movie);
    }
}