using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlazorPractice.Api.Data.Concrete
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Person> GetAllPerson(PaginationDto paginationDto)
        {
            return _context.People
                .Skip((paginationDto.PageNumber - 1) * (paginationDto.RecordsPerPage))
                .Take(paginationDto.RecordsPerPage);
        }
        public IEnumerable<Person> GetAllPersonByName(string searchText)
        {
            return _context.People.Where(p => p.Name.ToLower().Contains(searchText.ToLower()));
        }
        public Person GetPersonById(int id)
        {
            return _context.People
                .Include(person => person.MoviePeople).ThenInclude(moviePerson => moviePerson.Movie)
                .FirstOrDefault(p => p.Id == id);
        }

        public void CreatePerson(Person person)
        {
            _context.People.Add(person);
        }

        public void UpdatePerson(Person person)
        {

        }
        public void DeletePerson(Person person)
        {
            _context.People.Remove(person);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
