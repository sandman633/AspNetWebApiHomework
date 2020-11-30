using DataBase.Domain;
using Models.DTO;
using AutoMapper;

namespace Repositories.Mappings
{
    class EngineProfile : Profile
    {
        public EngineProfile()
        {
            CreateMap<Engine, EngineDto>().ReverseMap();
        }
    }
}
