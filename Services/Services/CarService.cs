using AutoMapper;
using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CarService : ICarService
    {
        /// <summary>
        /// Маппер
        /// и репозиторий
        /// </summary>
        private readonly ICarRepository _repository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Иницализируем поля
        /// </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="repository">Rep</param>
        public CarService(IMapper mapper, ICarRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
        /// <summary>
        /// Реализуем нужные интерфейсы
        /// </summary>

        public async Task<CarDto> CreateAsync(CarDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<CarDto>> GetAsync()
        {
            var engine = new Engine { Name = "V6", Type = "Disiel", Power = 180, Description = "V6 TurboDisiel 180 powered engine" };

            var manufacturer = new Manufacturer { Name = "Toyota", Year = 2010 };
            var shop = new Shop { Name = "TTS Auto", Phone = "55255255" };
            var car = new Car { Brand = manufacturer, Engine = engine, Model = "Camry", MaxSpeed = 240, Price = 2500000, Type = "Sedan"};
            var availability = new Availability { Car = car, Shop = shop };
            return await _repository.GetAsync();
        }

        public async Task<CarDto> GetAsyncById(long id)
        {
            return await _repository.GetAsyncById(id);
        }

        public async Task<CarDto> UpdateAsync(CarDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
