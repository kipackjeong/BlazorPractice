using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Dto.Genre
{
    public class ReadGenreDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
