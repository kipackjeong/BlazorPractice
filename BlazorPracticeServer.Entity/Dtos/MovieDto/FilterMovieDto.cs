using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPracticeServer.Entity.Dtos.MovieDto
{
    public class FilterMovieDto
    {
        public int PageNumber { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;

        public PaginationDto PaginationDto
        {
            get { return new PaginationDto() {PageNumber = PageNumber, RecordsPerPage = RecordsPerPage}; }
        }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public bool InTheaters { get; set; }
        public bool UpcomingReleases { get; set; }
    }
}
