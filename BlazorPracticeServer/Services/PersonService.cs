using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Services
{
    public class PersonService : IPersonService
    {
        private readonly IApiBroker _apiBroker;


        public PersonService(IApiBroker apiBroker)
        {
            _apiBroker = apiBroker;
        }

        public async ValueTask<IEnumerable<Person>> RetrieveAllPersonAsync() =>
            await _apiBroker.GetAllPersonAsync();

        public async ValueTask<Person> RetrievePersonByIdAsync(int id) =>
            await _apiBroker.GetPersonByIdAsync(id);

        public async ValueTask<IEnumerable<Person>> RetrievePeopleByName(string searchText) =>
            await _apiBroker.GetAllPeopleByName(searchText);

        public async ValueTask<Person> RegisterPersonAsync(Person genre) =>
            await _apiBroker.PostPersonAsync(genre);

        public async ValueTask<Person> UpdatePersonAsync(Person genre, int id) =>
            await _apiBroker.PutPersonAsync(genre, id);

        public async ValueTask<Person> DeletePersonAsync(int id) =>
            await _apiBroker.DeletePersonAsync(id);
    }
}
