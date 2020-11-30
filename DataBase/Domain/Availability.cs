using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// 
    /// TODO: добавить атрибуты
    /// </summary>
    class Availability
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Shop Shop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Car Car { get; set; }

    }
}
