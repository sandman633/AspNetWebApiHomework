using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// Описание обьекта автомобиль 
    /// </summary>
    public class Car : BaseEntity
    {
        /// <summary>
        /// Модель
        /// </summary>
        [StringLength(2500)]
        public string Model { get; set; }
        /// <summary>
        /// Марка авто
        /// </summary>
        [Required]
        public Manufacturer Brand { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        [Required]
        public Engine Engine { get; set; }
        /// <summary>
        /// Тип автомобиля
        /// (хэтчбэк, седан и тп)
        /// </summary>
        public long EngineId { get; set; }
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        [Required]
        [Range(1, 2100)]
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public double Price { get; set; }
        /// <summary>
        /// Наличие 
        /// </summary>
        public ICollection<Availability> Availabilities { get; set; }
    }
}
