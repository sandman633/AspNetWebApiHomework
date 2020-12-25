using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain.UserRoleModels
{
    /// <summary>
    /// Роли юзеров
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название роли
        /// </summary>
        public string Name { get; set; }
    }
}
