using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorPractice.Api.Data.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }


        public AllMoviesDto GetAllMovie()
        {
            var movieIndex = new AllMoviesDto();
            var todayDate = DateTime.UtcNow;
            movieIndex.InTheatersMovies =
                _context.Movies
                    .Where(m => m.InTheater)
                    .OrderBy(m => m.ReleaseDate)
                    .ToList();

            movieIndex.UpcomingMovies =
                _context.Movies
                    .Where(m => m.ReleaseDate > todayDate)
                    .ToList();
            movieIndex.OldMovies =
                _context.Movies
                    .Where(m => !m.InTheater && m.ReleaseDate < todayDate)
                    .ToList();

            return movieIndex;
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies
                .Include(movie => movie.MovieGenres).ThenInclude(movieGenre => movieGenre.Genre)
                .Include(movie => movie.MoviePeople).ThenInclude(moviePerson => moviePerson.Person)
                .FirstOrDefault(m => m.Id == id);
        }


        public IEnumerable<Movie> GetAllMovieByName(string movieName)
        {
            return _context.Movies
                .Where(movie => movieName != null 
                                && movie.Title
                                    .ToLower()
                                    .Contains(movieName.ToLower())
                                )
                .Take(10)
                .Include(movie => movie.MovieGenres).ThenInclude(movieGenre => movieGenre.Genre)
                .Include(movie => movie.MoviePeople).ThenInclude(moviePeople => moviePeople.Person);
        }

        public void CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {

        }

        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
