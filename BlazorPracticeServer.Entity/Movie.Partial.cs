using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorPracticeServer.Entity
{
    public partial class Movie
    {
        [NotMapped] public Genre Genre { get; set; }
    }
}
