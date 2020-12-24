using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.MovieDto;

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
