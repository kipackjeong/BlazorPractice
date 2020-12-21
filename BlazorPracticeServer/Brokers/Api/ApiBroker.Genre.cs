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
            await GetAsync<Genre>(_genreUrl);

        public async ValueTask<Genre> PostGenreAsync(Genre genre) =>
            await PostAsync(_genreUrl, genre);


    }
}
