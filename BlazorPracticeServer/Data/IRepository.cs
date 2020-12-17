using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Data
{
    public interface IRepository
    {
        List<Movie> Movies { get; set; }
        List<Genre> Genres { get; set; }
    }
}
