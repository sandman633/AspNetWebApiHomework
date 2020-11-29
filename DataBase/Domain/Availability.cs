using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// 
    /// TODO: добавить атрибуты
    /// </summary>
    public class Availability : BaseEntity
    {
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
