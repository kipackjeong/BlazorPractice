using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _movieUrl = "/api/movie";

        public async ValueTask<IEnumerable<Movie>> GetAllMovieAsync()
        {
            return await GetAllAsync<Movie>(_movieUrl);
        }

        public async ValueTask<Movie> PostMovieAsync(Movie movie)
        {
            return await PostAsync(_movieUrl, movie);
        }


        //TODO Movie API Broker Implement Put Patch Delete
    }
}