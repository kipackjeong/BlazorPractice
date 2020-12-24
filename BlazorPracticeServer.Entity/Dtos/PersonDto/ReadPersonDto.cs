using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorPracticeServer.Entity.Dtos.PersonDto
{
    public class ReadPersonDto
    {
        [Required]
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
