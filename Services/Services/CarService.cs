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
