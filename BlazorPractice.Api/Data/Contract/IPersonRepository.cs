using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos;
using System.Collections.Generic;

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
