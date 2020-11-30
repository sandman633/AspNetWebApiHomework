using DataBase.Domain;
using Models.DTO;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IEngineRepository : ICreateDto<EngineDto, Engine>, IDeletableById, IGetTable<EngineDto>
    {

    }
}
