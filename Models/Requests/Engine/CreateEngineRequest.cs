using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Requests.Car
{
    public class CreateEngineRequest
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Мощность
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
