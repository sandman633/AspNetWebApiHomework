using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// Описание обьекта автомобиль 
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Марка авто
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public Manufacturer Model { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public Engine Engine { get; set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public int Year { get; set; }
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
