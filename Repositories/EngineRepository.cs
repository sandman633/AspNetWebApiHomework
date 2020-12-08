using AutoMapper;
using DataBase.Context;
using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    class EngineRepository : BaseRepository<EngineDto, Engine>, IEngineRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="CarRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public EngineRepository(CarsContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

    }
}
