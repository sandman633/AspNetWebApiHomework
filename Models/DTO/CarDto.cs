using System.ComponentModel.DataAnnotations;
using DataBase.Domain;

namespace Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Car"/>
    /// </summary>
    public class CarDto : BaseDto
    {
        /// <summary>
        /// Марка авто
        /// </summary>
        public ManufacturerDto Brand { get; set; }
        public long BrandId { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public EngineDto Engine { get; set; }
        public long EngineId { get; set; }
        /// <summary>
        /// Тип автомобиля
        /// (хэтчбэк, седан и тп)
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
    }
}
