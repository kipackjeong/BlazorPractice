using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async ValueTask<Genre> RegisterGenreAsync(Genre genre) =>
            await _apiBroker.PostGenreAsync(genre);

        public async ValueTask<Genre> UpdateGenreAsync(Genre genre, int id) =>
            await _apiBroker.PutGenreAsync(genre, id);

        public async ValueTask<Genre> DeleteGenreAsync(int id) =>
            await _apiBroker.DeleteGenreAsync(id);
    }
}
