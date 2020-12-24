using System;
using System.ComponentModel.DataAnnotations;


namespace BlazorPracticeServer.Entity
{
    public class User
    {
        [Required] public string Name { get; set; }
        [Required] public DateTime SignUpDate { get; set; }
    }
}
