using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// Доменная модель
    /// </summary>
    public class Availability : BaseEntity
    {
        /// <summary>
        /// Магазины
        /// </summary>
        public Shop Shop { get; set; }
        /// <summary>
        /// Авто
        /// </summary>
        public Car Car { get; set; }

    }
}
