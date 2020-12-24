using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

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
