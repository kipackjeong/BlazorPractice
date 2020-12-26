using BlazorPracticeServer.Entity;
using System.Collections.Generic;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPerson();
        IEnumerable<Person> GetAllPersonByName(string searchText);
        Person GetPersonById(int id);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        bool SaveChanges();
    }
}
