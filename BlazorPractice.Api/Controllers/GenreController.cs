using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorPractice.Api.Data.Contract;
using BlazorPractice.Api.Dto.Genre;
using BlazorPractice.Api.Dto.Movie;
using BlazorPracticeServer.Entity;
using Microsoft.AspNetCore.JsonPatch;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller
    {
        private readonly IGenreRepository _repo;
        private readonly IMapper _mapper;

        public GenreController(IGenreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ReadGenreDto>> GetAllGenres()
        {
            var genres = _repo.GetAllGenres();
            return Ok(_mapper.Map<IEnumerable<ReadGenreDto>>(genres));
        }

        [HttpGet("{id}", Name = "GetGenreById")]
        public ActionResult<Genre> GetGenreById(int id)
        {
            Genre genre = _repo.GetGenreById(id);
            ReadGenreDto readGenre = _mapper.Map<ReadGenreDto>(genre);
            if (readGenre != null)
            {
                return Ok(readGenre);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult PostGenre(CreateGenreDto createGenreDto)
        {
            Genre genre = _mapper.Map<Genre>(createGenreDto);
            _repo.CreateGenre(genre);
            _repo.SaveChanges();

            ReadGenreDto readGenreDto = _mapper.Map<ReadGenreDto>(genre);

            return CreatedAtRoute(nameof(GetGenreById), new { id = genre.Id },readGenreDto);
        }

        [HttpPut("{id}")]
        public ActionResult PutGenre(int id, UpdateGenreDto updateGenreDto)
        {
            Genre genre = _repo.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
            }

            _mapper.Map(updateGenreDto, genre);
            _repo.UpdateGenre(genre);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PatchMovie(JsonPatchDocument<UpdateGenreDto> jsonDoc, int id)
        {
            Genre genre = _repo.GetGenreById(id);
            if (genre == null)
                return NotFound();
            UpdateGenreDto genreToPatch = _mapper.Map<UpdateGenreDto>(genre);

            jsonDoc.ApplyTo(genreToPatch);

            if (!TryValidateModel(genreToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(genreToPatch, genre);
            _repo.UpdateGenre(genre);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            Genre genre = _repo.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();

            }
            _repo.DeleteGenre(genre);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}
