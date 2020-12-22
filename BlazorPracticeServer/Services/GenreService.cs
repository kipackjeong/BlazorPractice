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
        private readonly IApiBroker _apiBroker;


        public GenreService(
            IApiBroker apiBroker)
        {
            this._apiBroker = apiBroker;
        }

        public async ValueTask<IEnumerable<Genre>> RetrieveAllGenreAsync() =>
            await _apiBroker.GetAllGenresAsync();

        public async ValueTask<Genre> RetrieveGenreByIdAsync(int id) =>
            await _apiBroker.GetGenreById(id);

        public async ValueTask<Genre> RegisterGenreAsync(Genre movie) =>
            await _apiBroker.PostGenreAsync(movie);

        public async ValueTask<Genre> UpdateGenreAsync(Genre movie, int id) =>
            await _apiBroker.PutGenreAsync(movie, id);

        public async ValueTask<Genre> DeleteGenreAsync(int id)=>
            await _apiBroker.DeleteGenreAsync(id);
    }
}
