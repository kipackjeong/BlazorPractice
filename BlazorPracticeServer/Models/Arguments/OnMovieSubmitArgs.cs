using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Models.Arguments
{
    public class OnMovieSubmitArgs : EventArgs
    {
        public Movie Movie { get; set; }
        public List<Person> People { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
