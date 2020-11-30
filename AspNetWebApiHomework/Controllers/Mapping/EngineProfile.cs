using AutoMapper;
using DataBase.Domain;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHomework.Controllers.Mapping
{
    public class EngineProfile : Profile
    {
        public EngineProfile()
        {
            CreateMap<Engine, EngineDto>().ReverseMap();
        }
    }
}
