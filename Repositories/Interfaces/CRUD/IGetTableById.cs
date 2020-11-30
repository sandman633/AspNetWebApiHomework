using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    public interface IGetTableById<TDto, TModel>
    {
        Task<TDto> GetAsyncById(long id);
    }
}
