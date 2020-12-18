using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker : IApiBroker
    {
        private const string _relativeUrl = "api/movie";

        public async ValueTask<Movie> GetMovieAsync(int id) =>
            await this.GetAsync<Movie>(_relativeUrl + "/" + id);

        public async ValueTask<Movie> PostMovieAsync(Movie movie) =>
            await this.PostAsync(_relativeUrl, movie);
        //TODO 1: Implement PUT , DELETE
    }
}
