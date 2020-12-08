using DataBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IContext
    {
         CarsContext Context { get; }
    }
}
