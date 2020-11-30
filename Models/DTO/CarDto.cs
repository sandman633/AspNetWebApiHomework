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
        [Required]
        [StringLength(200)]
        public ManufacturerDto Brand { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Model { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        [Required]
        [StringLength(100)]
        public EngineDto EngineType { get; set; }
        /// <summary>
        /// Тип автомобиля
        /// (хэтчбэк, седан и тп)
        /// </summary>
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        [Range(1, 2100)]
        [Required]
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public double Price { get; set; }
    }
}
