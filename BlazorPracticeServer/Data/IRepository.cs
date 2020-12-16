using System.Collections.Generic;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Data
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
