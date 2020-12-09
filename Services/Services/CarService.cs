using AutoMapper;
using DataBase.Domain;
using Models.DTO;
using Repositories;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    /// <summary>
    /// Сервир для работы с <see cref="CarRepository"/>
    /// </summary>
    public class CarService : ICarService
    {
        /// <summary>
        /// Маппер
        /// и репозиторий
        /// </summary>
        private readonly UnitOfWork _unit;
        private readonly IMapper _mapper;
        /// <summary>
        /// Иницализируем поля
        /// </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="repository">UnitOfWork</param>
        public CarService(IMapper mapper, UnitOfWork repository)
        {
            _unit = repository;
            _mapper = mapper;
        }
        /// <summary>
        /// Реализуем нужные интерфейсы
        /// </summary>

        public async Task<CarDto> CreateAsync(CarDto dto)
        {
            using var scope = _unit.carsRepository.Context.Database.BeginTransaction();
            try
            {
                var car = await _unit.carsRepository.CreateAsync(dto);
                _unit.Save();
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
            using var transaction = _unit.carsRepository.Context.Database.BeginTransaction();
            try
            {
                await _unit.carsRepository.DeleteByIdAsync(id);
                _unit.Save();
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
            return await _unit.carsRepository.GetAsync();
        }

        public async Task<CarDto> GetAsyncById(long id)
        {
            return await _unit.carsRepository.GetAsyncById(id);
        }

        public async Task<CarDto> SwapEngine(long id, string engineName)
        {
            using var transaction = _unit.carsRepository.Context.Database.BeginTransaction();
            try
            {
                var car = await _unit.carsRepository.SwapEngine(id, engineName);
                _unit.Save();
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
            using var transaction = _unit.carsRepository.Context.Database.BeginTransaction();
            try
            {
                var car = await _unit.carsRepository.UpdateAsync(dto);
                _unit.Save();
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
