using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<AllMoviesDto> GetAllMovieAsync();
        ValueTask<Movie> GetMovieByIdAsync(int id);
        ValueTask<IEnumerable<Movie>> GetAllMovieAsync(string searchFilter);
        ValueTask<Movie> PostMovieAsync(Movie movie);
        ValueTask<Movie> PutMovieAsync(Movie movie, int id);
        ValueTask<Movie> DeleteMovieAsync(int id);
    }
}