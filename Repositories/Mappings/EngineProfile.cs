using DataBase.Domain;
using Models.DTO;
using AutoMapper;

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
