using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<Genre>> GetAllGenresAsync();
        ValueTask<Genre> PostGenreAsync(Genre movie);
    }
}
