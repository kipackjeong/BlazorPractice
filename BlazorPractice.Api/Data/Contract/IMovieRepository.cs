
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;
using System.Collections.Generic;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IMovieRepository
    {
        AllMoviesDto GetAllMovie();
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovieByName(string movieName);
        void CreateMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(Movie movie);
        bool SaveChanges();
    }
}
