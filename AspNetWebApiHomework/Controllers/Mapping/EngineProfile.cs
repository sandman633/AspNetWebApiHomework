using AutoMapper;
using Models.DTO;
using Models.Requests.Car;
using Models.Responses.Engine;


namespace AspNetWebApiHomework.Controllers.Mapping
{
    public class EngineProfile : Profile
    {
        /// <summary>
        /// Добавляем карты маппинга для <see cref="EngineResponse"/> <see cref="CreateEngineRequest"/> <see cref="UpdateEngineRequest"/>/>
        /// </summary>
        public EngineProfile()
        {
            CreateMap<CreateEngineRequest, EngineDto>();
            CreateMap<UpdateEngineRequest, EngineDto>();
            CreateMap<EngineDto, EngineResponse>();
        }
    }
}
