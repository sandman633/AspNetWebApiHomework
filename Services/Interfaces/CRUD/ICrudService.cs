using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces.CRUD
{
    public interface ICrudService<TDto> :
            ICreateDto<TDto>,
            IGetTableById<TDto>,
            IGetTable<TDto>,
            IUpdatable<TDto>,
            IDeletableById
    {
    }
}
