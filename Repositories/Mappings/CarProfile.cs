using AutoMapper;
using DataBase.Domain;
using Models.DTO;


namespace Repositories.Mappings
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarDto, Car>().ReverseMap();
        }
    }
}
