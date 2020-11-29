using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IEngineService : ICreateDto<EngineDto>, IDeletableById
    {
    }
}
