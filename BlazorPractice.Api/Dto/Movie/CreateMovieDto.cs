using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPractice.Api.Dto.Movie
{
    public class CreateMovieDto
    {
        [Required] public string Title { get; set; }
        [Required] public string Summary { get; set; }
        [Required] public DateTime ReleaseDate { get; set; }
        [Required] public string Poster { get; set; }
        [Required] public bool InTheater { get; set; }
        [Required] public string Trailer { get; set; }
    }
}
