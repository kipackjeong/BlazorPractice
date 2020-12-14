using BlazorPracticeServer.Model;
using System.Collections.Generic;

namespace BlazorPracticeServer.Data
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
