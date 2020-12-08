using DataBase.Context;
using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория для работы с Car
    /// </summary>
    public interface ICarRepository: ICrudRepository<CarDto,Car>
    {
        CarsContext Context { get; }
    }
}
