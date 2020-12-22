using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<Movie>> GetAllMovieAsync();
        ValueTask<Movie> GetMovieByIdAsync(int id);
        ValueTask<Movie> PostMovieAsync(Movie movie);
        ValueTask<Movie> PutMovieAsync(Movie movie, int id);
        ValueTask<Movie> DeleteMovieAsync(int id);
    }
}