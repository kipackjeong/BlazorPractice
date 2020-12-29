using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPracticeServer.Entity.Dtos
{
    public class PaginationDto
    {
        public const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
    }
}
