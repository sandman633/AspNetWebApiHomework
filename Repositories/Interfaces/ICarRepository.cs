using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    /// <summary>
    /// интерфейс сервиса для работы 
    /// </summary>
    public interface ICarRepository: ICrudRepository<CarDto,Car>
    {
    }
}
