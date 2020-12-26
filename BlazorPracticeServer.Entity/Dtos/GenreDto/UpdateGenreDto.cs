using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity.Dtos.GenreDto
{
    public class UpdateGenreDto
    {
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
