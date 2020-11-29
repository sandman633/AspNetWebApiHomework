using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    public interface IGetTableById<TDto>
    {
        Task<IEnumerable<TDto>> GetByIdAsync(long id);
    }
}
