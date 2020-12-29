using AutoMapper;
using BlazorPractice.Api.Data.Contract;
using BlazorPractice.Api.Helper;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public MovieController(IMovieRepository repo, IMapper mapper, IFileStorageService fileStorageService)
        {
            _repo = repo;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }
        [HttpGet]
        public async ValueTask<ActionResult<AllMoviesDto>> GetAllMovies()
        {
            var allMovieDto = _repo.GetAllMovie();

            return Ok(allMovieDto);
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public async ValueTask<ActionResult<Movie>> GetMovieById(int id)
        {
            Movie movie = _repo.GetMovieById(id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();
        }

        [HttpGet("filter")]
        public async ValueTask<ActionResult<IEnumerable<ReadMovieDto>>> GetAllFilteredMovies([FromQuery]FilterMovieDto filterMovieDto)
        {
            var filteredMovies = _repo.GetAllFilteredMovies(filterMovieDto);
            if (!filteredMovies.Any())
            {
                return Ok(new List<ReadMovieDto>());
            }
            var filteredReadMovieDto = _mapper.Map<IEnumerable<ReadMovieDto>>(filteredMovies);
            return Ok(filteredReadMovieDto);
        }

        [HttpGet("search/{searchText}")]
        public async ValueTask<ActionResult<IEnumerable<ReadMovieDto>>> GetAllMovieByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new List<ReadMovieDto>();

            IEnumerable<Movie> filteredMovies = _repo.GetAllMovieByName(searchText);

            if (filteredMovies == null || !filteredMovies.Any())
                return new List<ReadMovieDto>();

            IEnumerable<ReadMovieDto> filteredReadMovie = _mapper.Map<IEnumerable<ReadMovieDto>>(filteredMovies);

            return Ok(filteredReadMovie);
        }

        [HttpPost]
        public async ValueTask<ActionResult> PostMovie(CreateMovieDto createMovieDto)
        {
            if (!string.IsNullOrWhiteSpace(createMovieDto.Poster))
            {
                var moviePoster = Convert.FromBase64String(createMovieDto.Poster);
                createMovieDto.Poster = await _fileStorageService.SaveFile(moviePoster, "jpg", "movies");
            }

            Movie movie = _mapper.Map<Movie>(createMovieDto);
            _repo.CreateMovie(movie);
            _repo.SaveChanges();

            ReadMovieDto readMovieDto = _mapper.Map<ReadMovieDto>(movie);

            return CreatedAtRoute(nameof(GetMovieById), new { id = movie.Id }, readMovieDto);
        }

        [HttpPut("{id}")]
        public async ValueTask<ActionResult> PutMovie(int id, UpdateMovieDto updateMovieDto)
        {
            if (_fileStorageService.IsBase64(updateMovieDto.Poster))
            {
                var personPicture = Convert.FromBase64String(updateMovieDto.Poster);
                updateMovieDto.Poster = await _fileStorageService.SaveFile(personPicture, "jpg", "people");
            }

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
        public async ValueTask<ActionResult> PatchMovie(JsonPatchDocument<UpdateMovieDto> jsonDoc, int id)
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
        public async ValueTask<ActionResult> DeleteMovie(int id)
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
