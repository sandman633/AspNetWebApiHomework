using AutoMapper;
using DataBase.Mocks;
using Models.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    /// <summary>
    /// сервис выполняющий две функции:
    /// получение данных из мок обьекта и удаление
    /// </summary>
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;

        public CarService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public bool DeleteCarById(int id)
        {
            var result = CarMock.FindCarById(id);
            if (result)
            {
                CarMock.DeleteCarById(id);
                return result;
            }
            else
            {
                return result;
            }
        }


        public IEnumerable<CarDto> GetCars()
        {
            var cars = CarMock.GetCars();
            var response = _mapper.Map<IEnumerable<CarDto>>(cars);
            return response;
        }
    }
}
