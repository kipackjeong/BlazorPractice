using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Services
{
    public interface IPersonService
    {
        ValueTask<IEnumerable<Person>> RetrieveAllPersonAsync();
        ValueTask<Person> RetrievePersonByIdAsync(int id);
        ValueTask<IEnumerable<Person>> RetrievePeopleByName(string searchText);
        ValueTask<Person> RegisterPersonAsync(Person person);
        ValueTask<Person> UpdatePersonAsync(Person person, int id);
        ValueTask<Person> DeletePersonAsync(int id);
    }
}
