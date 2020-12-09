using DataBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    /// <summary>
    /// интерфейс для доступа к контексту бд
    /// </summary>
    public interface IContext
    {
         CarsContext Context { get; }
    }
}
