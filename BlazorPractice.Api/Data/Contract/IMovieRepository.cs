using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovie();
        Movie GetMovieById(int id);
        void CreateMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(Movie movie);
        bool SaveChanges();
    }
}
