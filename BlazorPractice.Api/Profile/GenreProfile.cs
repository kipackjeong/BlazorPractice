using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.GenreDto;

namespace BlazorPractice.Api.Profile
{
    public class GenreProfile : AutoMapper.Profile
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
