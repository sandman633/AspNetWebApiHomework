using AutoMapper;
using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
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
            using var scope = _repository.Context.Database.BeginTransaction();
            try
            {
                var car = await _repository.CreateAsync(dto);
                await scope.CommitAsync();
                return car;
            }
            catch(Exception e)
            {
                scope.Rollback();
                throw e;
            }
        }

        public async Task DeleteAsync(long id)
        {
            using var transaction = _repository.Context.Database.BeginTransaction();
            try
            {
                await _repository.DeleteByIdAsync(id);
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
            
        }

        public async Task<IEnumerable<CarDto>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<CarDto> GetAsyncById(long id)
        {
            return await _repository.GetAsyncById(id);
        }

        public async Task<CarDto> SwapEngine(long id, string engineName)
        {
            using var transaction = _repository.Context.Database.BeginTransaction();
            try
            {
                var car = await _repository.SwapEngine(id, engineName);
                transaction.Commit();
                return await GetAsyncById(id);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
        }

        public async Task<CarDto> UpdateAsync(CarDto dto)
        {
            using var transaction = _repository.Context.Database.BeginTransaction();
            try
            {
                var car = await _repository.UpdateAsync(dto);
                transaction.Commit();
                return  car;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
        }
    }
}
