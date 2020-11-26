using AutoMapper;
using DataBase.Domain;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга
    /// </summary>
    class CarProfile  : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>();
        }
    }
}
