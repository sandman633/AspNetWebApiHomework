using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    public interface IUpdatable<TDto>
    {
        Task<TDto> UpdateAsync(TDto dto);
    }
}
