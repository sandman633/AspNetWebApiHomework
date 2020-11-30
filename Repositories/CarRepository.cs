using AutoMapper;
using DataBase.Context;
using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
