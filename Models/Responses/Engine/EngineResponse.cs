using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Responses.Engine
{
    public class EngineResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
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
