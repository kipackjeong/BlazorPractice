using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorPracticeServer.Entity
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }

        //public string TitleBrief
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(Title))
        //        {
        //            return null;
        //        }
        //        if (Title.Length > 15)
        //        {
        //            return Title.Substring(0, 15) + "...";
        //        }
        //        else
        //        {
        //            return Title;
        //        }
        //    }
        //}
    }
}
