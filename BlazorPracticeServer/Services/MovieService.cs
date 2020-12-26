using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IApiBroker _apiBroker;


        public MovieService(IApiBroker apiBroker)
        {
            _apiBroker = apiBroker;
        }

        public async ValueTask<AllMoviesDto> RetrieveAllMovieAsync() =>
            await _apiBroker.GetAllMovieAsync();

        public async ValueTask<Movie> RetrieveMovieByIdAsync(int id) =>
            await _apiBroker.GetMovieByIdAsync(id);

        public async ValueTask<IEnumerable<Movie>> RetrieveMovieByNameAsync(string searchText) =>
            await _apiBroker.GetAllMovieByName(searchText);


        public async ValueTask<Movie> RegisterMovieAsync(Movie movie) =>
            await _apiBroker.PostMovieAsync(movie);

        public async ValueTask<Movie> UpdateMovieAsync(Movie movie, int id) =>
            await _apiBroker.PutMovieAsync(movie, id);

        public async ValueTask<Movie> DeleteMovieAsync(int id) =>
            await _apiBroker.DeleteMovieAsync(id);
    }
}
