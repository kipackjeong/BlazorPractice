using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity.Dtos.GenreDto
{
    public class CreateGenreDto
    {
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
    }
}
