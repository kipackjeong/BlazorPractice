using BlazorPracticeServer.Entity;
using System.Collections.Generic;

namespace BlazorPracticeServer.Data
{
    public interface IRepository
    {
        List<Movie> Movies { get; set; }
        List<Genre> Genres { get; set; }
    }
}
