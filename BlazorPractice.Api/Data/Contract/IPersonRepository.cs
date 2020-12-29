using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPerson(PaginationDto paginationDto);
        IEnumerable<Person> GetAllPersonByName(string searchText);
        Person GetPersonById(int id);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        bool SaveChanges();
    }
}
