using AutoMapper;
using DataBase.Context;
using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Реализация конкретного репозитория
    /// </summary>
    public class CarRepository : BaseRepository<CarDto, Car>, ICarRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="CarRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public CarRepository(CarsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Car> DefaultInclude(DbSet<Car> dbSet)
        {
            return _dbSet.Include(x => x.Engine).Include(x => x.Brand).AsNoTracking();
        }
        /// <summary>
        /// Метод для изменения двигателя в автомобиле
        /// </summary>
        /// <param name="id">id авто</param>
        /// <param name="engineName">название двигателя</param>
        /// <returns></returns>
        public async Task<CarDto> SwapEngine(long id, string engineName)
        {
            var car = await DefaultInclude(_dbSet).FirstOrDefaultAsync(x => x.Id == id);
            var engine = await Context.Engines.FirstOrDefaultAsync(x => x.Name == engineName);
            if(engine!=null && car!= null)
                car.Engine = engine;
            _dbSet.Update(car);
            return  _mapper.Map<CarDto>(car);
        }
    }
}
