using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces.CRUD
{
    public interface ICrudRepository<TDto,TModel> :
        ICreateDto<TDto, TModel>,
        IGetTableById<TDto, TModel>,
        IGetTable<TDto>,
        IUpdatable<TDto>,
        IDeletableById,
        IContext
    {
    }
}
