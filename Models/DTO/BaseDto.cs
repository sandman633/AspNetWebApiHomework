using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    /// <summary>
    /// Базовый тип для всех моделей Dto
    /// </summary>
    public abstract class BaseDto
    {
        public long Id { get; set; }
    }
}
