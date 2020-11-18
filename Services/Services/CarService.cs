using AutoMapper;
using DataBase.Mocks;
using Models.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;

        public CarService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public IEnumerable<CarDto> GetCars()
        {
            var cars = CarMock.GetCars();
            var response = _mapper.Map<IEnumerable<CarDto>>(cars);
            return response;
        }
    }
}
