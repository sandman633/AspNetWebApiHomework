using Models.DTO;
using Repositories.Interfaces.CRUD;
using System.Collections.Generic;

namespace Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с автомобилями
    /// </summary>
    public interface ICarService : ICrudService<CarDto>,ISwapEngine<CarDto>
    {
    }
}
