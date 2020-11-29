using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    public interface ICreateDto<TDto>
    {
        Task<TDto> CreateAsync(TDto dto);
    }
}
