using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _genreUrl = "/api/genre";

        public async ValueTask<IEnumerable<Genre>> GetAllGenresAsync()=>
            await GetAllAsync<Genre>(_genreUrl);

        public async ValueTask<Genre> GetGenreById(int id) =>
            await GetAsync<Genre>(_genreUrl + "/" + id.ToString());

        public async ValueTask<Genre> PostGenreAsync(Genre genre) =>
            await PostAsync(_genreUrl, genre);

        //TODO Genre Broker : Implement Put, Patch, and Delete

    }
}
