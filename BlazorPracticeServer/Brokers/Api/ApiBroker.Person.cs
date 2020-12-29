using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _personUrl = "/api/person";

        public async ValueTask<IEnumerable<Person>> GetAllPersonAsync(string queryString) =>
            await GetAllAsync<Person>(_personUrl + queryString);

        public async ValueTask<Person> GetPersonByIdAsync(int id) =>
            await GetAsync<Person>(_personUrl + $"/{id}");

        public async ValueTask<IEnumerable<Person>> GetAllPeopleByName(string searchText) =>
            await GetAllAsync<Person>(_personUrl + $"/search/{searchText}");

        public async ValueTask<Person> PostPersonAsync(Person person) =>
            await PostAsync(_personUrl, person);

        public async ValueTask<Person> PutPersonAsync(Person person, int id) =>
            await PutAsync(_personUrl + $"/{id}", person);

        public async ValueTask<Person> DeletePersonAsync(int id) =>
            await DeleteAsync<Person>(_personUrl + $"/{id}");
    }
}
