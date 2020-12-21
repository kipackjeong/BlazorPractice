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
            return await GetAsync<Movie>(_movieUrl);
        }

        public async ValueTask<Movie> PostMovieAsync(Movie movie)
        {
            return await PostAsync(_movieUrl, movie);
        }


        //TODO 3: Implement Put and Delete in Movie ApiBroker
    }
}