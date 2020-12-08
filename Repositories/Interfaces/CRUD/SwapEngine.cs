using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    interface SwapEngine<TDto>
    {
        Task<TDto> SwapEngine(TDto dto); 
    }
}
