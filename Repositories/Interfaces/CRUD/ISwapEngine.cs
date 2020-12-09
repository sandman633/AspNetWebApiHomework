using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    public interface ISwapEngine<TDto>
    {
        Task<TDto> SwapEngine(long id, string engineName); 
    }
}
