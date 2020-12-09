using AutoMapper;
using DataBase.Domain;
using Models.DTO;

namespace Repositories.Mappings
{
    public class EngineProfile : Profile
    {
        public EngineProfile()
        {
            CreateMap<Engine, EngineDto>().ReverseMap();
        }
    }
}
