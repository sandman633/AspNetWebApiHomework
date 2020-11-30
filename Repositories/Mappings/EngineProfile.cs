using DataBase.Domain;
using Models.DTO;
using AutoMapper;

namespace Repositories.Mappings
{
    public class EngineProfile : Profile
    {
        /// <summary>
        /// Profile маппинга
        /// </summary>
        public EngineProfile()
        {
            CreateMap<Engine, EngineDto>().ReverseMap();
        }
    }
}
