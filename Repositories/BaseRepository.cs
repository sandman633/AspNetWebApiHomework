using AutoMapper;
using DataBase.Context;
using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Реализация базового репозитория 
    /// </summary>
    /// <typeparam name="TDto"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel> 
        where TDto : BaseDto
        where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected readonly CarsContext _context;
        protected DbSet<TModel> _dbSet => _context.Set<TModel>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">Контекст бд</param>
        /// <param name="mapper">маппер</param>
        protected BaseRepository(CarsContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        /// <summary>
        /// Методы реализующие интерфейсы Репозитория
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await GetAsyncById(entity.Id);
        }

        public async Task<TDto> GetAsyncById(long id)
        {
            var entity = await _dbSet
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<IEnumerable<TDto>> GetAsync()
        {
            var entities = await _dbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            _context.Update(entity);
            await _context.SaveChangesAsync();
            var newEntity = await GetAsyncById(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        public async Task DeleteByIdAsync(long id)
        {
            var entities = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            _context.Remove(entities);
            await _context.SaveChangesAsync();
        }

        public virtual  IQueryable<TModel> DefaultInclude(DbSet<TModel> dbSet) => dbSet;
    }
}
