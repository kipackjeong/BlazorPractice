using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity
{
    public class Movie
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Summary { get; set; }
        [Required] public DateTime? ReleaseDate { get; set; }
        [Required] public string Poster { get; set; }
        [Required] public bool InTheater { get; set; }
        [Required] public string Trailer { get; set; }
        public IEnumerable<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public IEnumerable<MoviePerson> MoviePeople { get; set; } = new List<MoviePerson>();
    }
}
