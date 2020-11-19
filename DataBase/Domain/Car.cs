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
        public string Model { get; set; }
        /// <summary>
        /// тип двигателя
        /// </summary>
        public string EngineType { get; set; }
        /// <summary>
        /// год выпуска
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// тип автомобиля
        /// (хэтчбэк, седан и тп)
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// максимальная скорость
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// цена
        /// </summary>
        public double Price { get; set; }
    }
}
