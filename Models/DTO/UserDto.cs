using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class UserDto : BaseDto
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}
