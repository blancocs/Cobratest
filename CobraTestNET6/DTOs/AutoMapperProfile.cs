using AutoMapper;
using CobraTestNET6.Entities.Models;

namespace CobraTestNET6.DTOs
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() { 
            CreateMap<Car,CarDTO>();
            CreateMap<CarDTO,Car >();

        }
    }
}
