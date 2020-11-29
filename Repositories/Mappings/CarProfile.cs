using DataBase.Domain;
using Models.DTO;
using AutoMapper;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Mappings
{
    /// <summary>
    /// Профиль маппинга
    /// </summary>
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
        }
    }
}
