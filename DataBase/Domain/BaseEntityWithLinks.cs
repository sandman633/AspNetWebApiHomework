using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    /// <summary>
    /// Класс для слабосвязанных сущностьей
    /// </summary>
    /// <typeparam name="TEntity1">сущность1</typeparam>
    /// <typeparam name="TEntity2">сущность2</typeparam>
    public class BaseEntityWithLinks<TEntity1,TEntity2> where TEntity1 : BaseEntity
        where TEntity2 : BaseEntity
    {
        /// <summary>
        /// Связанные сущности и их Ид
        /// </summary>
        public TEntity1 Entity1 { get; set; }
        public long Entity1Id { get; set; }
        public TEntity2 Entity2 { get; set; }
        public long Entity2Id { get; set; }
    }
}
