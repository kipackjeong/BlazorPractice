using System.Collections.Generic;
using BlazorPracticeServer.Entity;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos.MovieDto;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<AllMoviesDto> GetAllMovieAsync();
        ValueTask<Movie> GetMovieByIdAsync(int id);
        ValueTask<IEnumerable<Movie>> GetAllMovieByName(string searchText);
        ValueTask<Movie> PostMovieAsync(Movie movie);
        ValueTask<Movie> PutMovieAsync(Movie movie, int id);
        ValueTask<Movie> DeleteMovieAsync(int id);
    }
}