﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для получения сущности по идентификатору.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IGetTableById<TDto, TModel>
    {
        /// <summary>
        /// Получение сущности по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Экземпляр сущности.</returns>
        Task<TDto> GetAsyncById(long id);
    }
}
