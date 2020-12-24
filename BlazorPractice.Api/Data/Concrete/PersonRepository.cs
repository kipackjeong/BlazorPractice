using System.Collections.Generic;
using System.Linq;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Data.Concrete
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Person> GetAllPerson()
        {
            return _context.People.ToList();
        }
        public IEnumerable<Person> GetAllPersonByName(string searchText)
        {
            return _context.People.Where(p => p.Name.ToLower().Contains(searchText.ToLower())); 
        }
        public Person GetPersonById(int id)
        {
            return _context.People.FirstOrDefault(p => p.Id == id);
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
