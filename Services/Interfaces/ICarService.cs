using Models.DTO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDto> GetCars();
    }
}
