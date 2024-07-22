using AutoMapper;
using Assignment_2_API.Models;

namespace Assignment_2_API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }

    }
}
