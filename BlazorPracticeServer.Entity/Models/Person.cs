using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPracticeServer.Entity
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        public IEnumerable<MoviePerson> MoviePeople { get; set; } = new List<MoviePerson>();


        [NotMapped]
        public string Character { get; set; }

    }
}
