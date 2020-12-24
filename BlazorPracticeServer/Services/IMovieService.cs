using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos.MovieDto;

namespace BlazorPracticeServer.Services
{
    public interface IMovieService
    {
        ValueTask<AllMoviesDto> RetrieveAllMovieAsync();
        ValueTask<Movie> RetrieveMovieByIdAsync(int id);
        ValueTask<IEnumerable<Movie>> RetrieveMovieByNameAsync(string searchText);
        ValueTask<Movie> RegisterMovieAsync(Movie movie);
        ValueTask<Movie> UpdateMovieAsync(Movie movie, int id);
        ValueTask<Movie> DeleteMovieAsync(int id);
    }
}