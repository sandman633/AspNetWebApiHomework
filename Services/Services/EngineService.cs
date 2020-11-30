using AutoMapper;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EngineService : IEngineService
    {
        public readonly IMapper _mapper;
        protected readonly IEngineRepository _repository;
        /// <summary>
        /// Иницализируем поля
        /// </summary>
        /// <param name="mapper">Маппер</param>
        /// <param name="repository">Rep</param>
        public EngineService(IMapper mapper, IEngineRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<EngineDto> CreateAsync(EngineDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<EngineDto>> GetAsync()
        {
            return await _repository.GetAsync();
        }
    }
}
