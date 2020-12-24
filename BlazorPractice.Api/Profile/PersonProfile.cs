using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Dtos.PersonDto;

namespace BlazorPractice.Api.Profile
{
    public class PersonProfile : AutoMapper.Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonDto, Person>();
            CreateMap<UpdatePersonDto, Person>();
            CreateMap<Person, UpdatePersonDto>();
            CreateMap<Person, ReadPersonDto>();
        }
    }
}
