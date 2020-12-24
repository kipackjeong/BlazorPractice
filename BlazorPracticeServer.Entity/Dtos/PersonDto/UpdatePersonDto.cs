using System;
using System.ComponentModel.DataAnnotations;


namespace BlazorPracticeServer.Entity.Dtos.PersonDto
{
    public class UpdatePersonDto
    {
        [Required]
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
