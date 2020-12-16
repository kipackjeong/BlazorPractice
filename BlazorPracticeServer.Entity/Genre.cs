using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

    }
}
