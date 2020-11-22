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
    /// Сервис выполняющий две функции:
    /// Получение данных из мок обьекта и удаление
    /// </summary>
    public class CarService : ICarService
    {
        /// <summary>
        /// Маппер
        /// </summary>
        private readonly IMapper _mapper;
        /// <summary>
        /// Иницализируем поля
        /// </summary>
        /// <param name="mapper">Маппер</param>
        public CarService(IMapper mapper)
        {
            _mapper = mapper;
        }
        /// <summary>
        /// Метод для удаления авто из Mock-объекта
        /// </summary>
        /// <param name="id">id нужного авто</param>
        /// <returns>Возвращает булевую переменную 
        /// true - операция успешна
        /// false - нет
        /// </returns>
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

        /// <summary>
        /// Возвращает коллекцию машин
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CarDto> GetCars()
        {
            var cars = CarMock.GetCars();
            var response = _mapper.Map<IEnumerable<CarDto>>(cars);
            return response;
        }
    }
}
