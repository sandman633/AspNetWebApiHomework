using System.ComponentModel.DataAnnotations;

namespace DataBase.Domain
{
    /// <summary>
    /// Описание сущности двигатель
    /// </summary>
    public class Engine : BaseEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// Мощность
        /// </summary>
        [Range(1, 2100)]
        [Required]
        public int Power { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        [StringLength(2500)]
        public string Description { get; set; }
    }
}
