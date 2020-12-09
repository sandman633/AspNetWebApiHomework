using AutoMapper;
using Models.DTO;
using Models.Requests.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHomework.Controllers.Mapping
{
    public class CarProfile : Profile
    {  
        /// <summary>
        /// Добавляем карты маппинга для <see cref="CarResponse"/> <see cref="CreateCarRequest"/> <see cref="UpdateCarRequest"/>/>
        /// </summary>
        public CarProfile()
        {
            CreateMap<CreateCarRequest, CarDto>();
            CreateMap<UpdateCarRequest, CarDto>();
            CreateMap<CarDto, CarResponse>().ForMember(x => x.BrandName, y => y.MapFrom(src => src.Brand.Name))
                .ForMember(x => x.EngineName, y => y.MapFrom(src => src.Engine.Name))
                .ForMember(x => x.EnginePower, y => y.MapFrom(src => src.Engine.Power));
        }

    }
}
