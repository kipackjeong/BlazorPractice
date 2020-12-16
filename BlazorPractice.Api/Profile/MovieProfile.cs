using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Dto.Movie;
using BlazorPracticeServer.Entity;

namespace BlazorPractice.Api.Profile
{
    public class MovieProfile : AutoMapper.Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, ReadMovieDto>();
            CreateMap<CreateMovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();
            CreateMap<Movie, UpdateMovieDto>();
        }
    }
}
