using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity
{
    public partial class Movie
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
