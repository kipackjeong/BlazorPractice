using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _movieUrl = "/api/movie";

        public async ValueTask<AllMoviesDto> GetAllMovieAsync() =>
            await GetAllIndexAsync<AllMoviesDto>(_movieUrl);

        public async ValueTask<IEnumerable<Movie>> GetAllMovieAsync(string searchFilter) =>
            await GetAllAsync<Movie>(_movieUrl + searchFilter);

        public async ValueTask<Movie> GetMovieByIdAsync(int id) =>
            await GetAsync<Movie>(_movieUrl + $"/{id}");

        public async ValueTask<Movie> PostMovieAsync(Movie movie) =>
            await PostAsync(_movieUrl, movie);

        public async ValueTask<Movie> PutMovieAsync(Movie movie, int id) =>
            await PutAsync(_movieUrl + $"/{id}", movie);

        public async ValueTask<Movie> DeleteMovieAsync(int id) =>
            await DeleteAsync<Movie>(_movieUrl + $"/{id}");
    }
}