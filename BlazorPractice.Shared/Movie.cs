using System;

namespace BlazorPracticeServer.Model
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public string TitleSize { get; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return null;
                }
                if (Title.Length > 15)
                {
                    return Title.Substring(0, 15) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }
    }
}
