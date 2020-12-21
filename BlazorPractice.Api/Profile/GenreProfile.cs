using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Dto.Genre;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Profile
{
    public class GenreProfile:AutoMapper.Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, ReadGenreDto>();
            CreateMap<CreateGenreDto, Genre>();
            CreateMap<UpdateGenreDto, Genre>();
            CreateMap<Genre, UpdateGenreDto>();
        }
    }
}
