using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<Movie>> GetAllMovieAsync();
        ValueTask<Movie> PostMovieAsync(Movie movie);
    }
}