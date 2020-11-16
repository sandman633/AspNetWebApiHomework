using System.ComponentModel.DataAnnotations;
using DataBase.Domain;

namespace Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Car"/>
    /// </summary>
    public class CarDto
    {
        /// <summary>
        /// Марка авто
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Brand { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Model { get; set; }
        /// <summary>
        /// тип двигателя
        /// </summary>
        [Required]
        [StringLength(100)]
        public string EngineType { get; set; }
        /// <summary>
        /// год выпуска
        /// </summary>
        [Required]
        public int Year { get; set; }
        /// <summary>
        /// тип автомобиля
        /// (хэтчбэк, седан и тп)
        /// </summary>
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// максимальная скорость
        /// </summary>
        [Range(1, 2100)]
        [Required]
        public int MaxSpeed { get; set; }
    }
}
