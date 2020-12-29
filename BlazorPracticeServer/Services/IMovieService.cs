using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Services
{
    public interface IMovieService
    {
        ValueTask<AllMoviesDto> RetrieveAllMovieAsync();
        ValueTask<Movie> RetrieveMovieByIdAsync(int id);
        ValueTask<IEnumerable<Movie>> RetrieveMovieByFilterAsync(FilterMovieDto filterMovieDto);
        ValueTask<Movie> RegisterMovieAsync(Movie movie);
        ValueTask<Movie> UpdateMovieAsync(Movie movie, int id);
        ValueTask<Movie> DeleteMovieAsync(int id);
    }
}