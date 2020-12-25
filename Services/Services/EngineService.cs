using AutoMapper;
using Models.DTO;
using Repositories;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EngineService : IEngineService
    {
        public readonly IMapper _mapper;
        protected readonly UnitOfWork _unit;
        /// <summary>
        /// Иницализируем поля
        /// </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="unit">Rep</param>
        public EngineService(IMapper mapper, UnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        /// <summary>
        /// Реализуем нужные интерфейсы
        /// </summary>
        public async Task<EngineDto> CreateAsync(EngineDto dto)
        {
            using var transaction = _unit.engineRepository.Context.Database.BeginTransaction();
            try
            {
                var engine = await _unit.engineRepository.CreateAsync(dto);
                _unit.Save();
                await transaction.CommitAsync();
                return engine;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }
        }

        public async Task DeleteAsync(long id)
        {
            using var transaction = _unit.engineRepository.Context.Database.BeginTransaction();
            try
            {
                await _unit.engineRepository.DeleteByIdAsync(id);
                _unit.Save();
                await transaction.CommitAsync();
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }
        }

        public async Task<IEnumerable<EngineDto>> GetAsync()
        {
            return await _unit.engineRepository.GetAsync();
        }
    }
}
