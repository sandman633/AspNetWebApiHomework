using DataBase.Domain;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Requests.Car
{
    public class CarResponse
    {
        public long Id { get; set; }
        /// <summary>
        /// Марка авто
        /// </summary>
        public ManufacturerDto Brand { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public EngineDto EngineType { get; set; }
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
