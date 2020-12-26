using BlazorPracticeServer.Entity;
using System;
using System.Collections.Generic;

namespace BlazorPracticeServer.Models.Arguments
{
    public class OnMovieSubmitArgs : EventArgs
    {
        public Movie Movie { get; set; }
        public List<Person> People { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
