using Models.DTO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с автомобилями
    /// </summary>
    public interface ICarService
    {
        IEnumerable<CarDto> GetCars();
        bool DeleteCarById(int id);
    }
}
