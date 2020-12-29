using AutoMapper;
using BlazorPractice.Api.Data.Contract;
using BlazorPractice.Api.Helper;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.PersonDto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repo;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public PersonController(IPersonRepository repo, IMapper mapper, IFileStorageService fileStorageService)
        {
            _repo = repo;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAllPerson([FromQuery]PaginationDto paginationDto)
        {
            var people = _repo.GetAllPerson(paginationDto);
            return Ok(people);
        }

        [HttpGet("{id}", Name = "GetPersonById")]
        public ActionResult<Movie> GetPersonById(int id)
        {
            Person person = _repo.GetPersonById(id);
            if (person != null)
            {
                return Ok(person);
            }
            return NotFound();
        }

        [HttpGet("search/{searchText}")]
        public async ValueTask<ActionResult<IEnumerable<ReadPersonDto>>> GetAllPersonByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return new List<ReadPersonDto>();
            }
            IEnumerable<Person> filteredPeople = _repo.GetAllPersonByName(searchText);
            if (filteredPeople == null)
            {
                return new List<ReadPersonDto>();
            }

            IEnumerable<ReadPersonDto> filteredReadPeopleDto = _mapper.Map<IEnumerable<ReadPersonDto>>(filteredPeople);

            return Ok(filteredReadPeopleDto);
        }

        [HttpPost]
        public async Task<ActionResult> PostPerson(CreatePersonDto createPersonDto)
        {
            if (!string.IsNullOrWhiteSpace(createPersonDto.Picture))
            {
                var personPicture = Convert.FromBase64String(createPersonDto.Picture);
                createPersonDto.Picture = await _fileStorageService.SaveFile(personPicture, "jpg", "people");
            }

            Person person = _mapper.Map<Person>(createPersonDto);
            _repo.CreatePerson(person);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetPersonById), new { id = person.Id }, person);
        }

        [HttpPut("{id}")]
        public async ValueTask<ActionResult> PutPerson(int id, UpdatePersonDto updatePersonDto)
        {
            if (_fileStorageService.IsBase64(updatePersonDto.Picture))
            {
                var personPicture = Convert.FromBase64String(updatePersonDto.Picture);
                updatePersonDto.Picture = await _fileStorageService.SaveFile(personPicture, "jpg", "people");
            }


            Person person = _repo.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            _mapper.Map(updatePersonDto, person);
            _repo.UpdatePerson(person);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PatchMovie(JsonPatchDocument<UpdatePersonDto> jsonDoc, int id)
        {
            Person person = _repo.GetPersonById(id);
            if (person == null)
                return NotFound();
            UpdatePersonDto personToPatch = _mapper.Map<UpdatePersonDto>(person);

            jsonDoc.ApplyTo(personToPatch);

            if (!TryValidateModel(personToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(personToPatch, person);
            _repo.UpdatePerson(person);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            Person person = _repo.GetPersonById(id);
            if (person == null)
            {
                return NotFound();

            }
            _repo.DeletePerson(person);
            _repo.SaveChanges();

            return NoContent();
        }

    }
}
