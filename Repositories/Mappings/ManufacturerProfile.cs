using AutoMapper;
using DataBase.Domain;
using Models.DTO;

namespace Repositories.Mappings
{
    public class ManufacturerProfile : Profile
    {
        public ManufacturerProfile()
        {
            CreateMap<ManufacturerDto, Manufacturer>().ReverseMap();
        }
    }
}
