using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPracticeServer.Entity.Models
{
    public class Rating
    {
        public const int MaxRating = 5;
        public int UserRating { get; set; }
        public int movieId { get; set; }
        public int userId { get; set; }
    }
}
