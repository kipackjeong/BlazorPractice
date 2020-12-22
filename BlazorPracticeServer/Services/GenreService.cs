using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Services
{
    public class GenreService : IGenreService
    {
        private readonly IApiBroker apiBroker;


        public GenreService(
            IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async ValueTask<IEnumerable<Genre>> RetrieveAllGenreAsync() =>
            await apiBroker.GetAllGenresAsync();

        public async ValueTask<Genre> RetrieveGenreByIdAsync(int id) =>
            await apiBroker.GetGenreById(id);

        public async ValueTask<Genre> RegisterGenreAsync(Genre movie) =>
            await this.apiBroker.PostGenreAsync(movie);
    }
}
