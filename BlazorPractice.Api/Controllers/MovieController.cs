using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorPractice.Api.Data.Concrete;
using BlazorPractice.Api.Data.Contract;
using BlazorPractice.Api.Dto.Movie;
using BlazorPracticeServer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;

namespace BlazorPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private IMovieRepository _repo;
        private IMapper _mapper;

        public MovieController(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = _repo.GetAllMovie();
            return Ok(_mapper.Map<IEnumerable<Movie>>(movies));
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            Movie movie = _repo.GetMovieById(id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult PostMovie(CreateMovieDto createMovieDto)
        {
            Movie movie = _mapper.Map<Movie>(createMovieDto);
            _repo.CreateMovie(movie);
            _repo.SaveChanges();

            ReadMovieDto readMovieDto = _mapper.Map<ReadMovieDto>(movie);

            return CreatedAtRoute(nameof(GetMovieById), new { id = movie.Id }, readMovieDto);
        }

        [HttpPut("{id}")]
        public ActionResult PutMovie(int id, UpdateMovieDto updateMovieDto)
        {
            Movie movie = _repo.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }

            _mapper.Map(updateMovieDto, movie);
            _repo.UpdateMovie(movie);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PatchMovie(JsonPatchDocument<UpdateMovieDto> jsonDoc, int id)
        {
            Movie movie = _repo.GetMovieById(id);
            if (movie == null)
                return NotFound();
            UpdateMovieDto movieToPatch = _mapper.Map<UpdateMovieDto>(movie);

            jsonDoc.ApplyTo(movieToPatch);

            if (!TryValidateModel(movieToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(movieToPatch, movie);
            _repo.UpdateMovie(movie);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            Movie movie = _repo.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();

            }
            _repo.DeleteMovie(movie);
            _repo.SaveChanges();

            return NoContent();
        }


    }
}
