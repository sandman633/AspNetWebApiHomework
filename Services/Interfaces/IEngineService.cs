using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с Engine
    /// </summary>
    public interface IEngineService : ICreateDto<EngineDto>, IGetTable<EngineDto>, IDeletableById
    {
    }
}
