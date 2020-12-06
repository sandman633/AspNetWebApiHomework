using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// Доменная модель
    /// </summary>
    public class Availability : BaseEntityWithLinks<Car, Shop>
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        public int Count { get; set; }

    }
}
