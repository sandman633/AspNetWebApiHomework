using System.ComponentModel.DataAnnotations;

namespace DataBase.Domain
{
    /// <summary>
    /// Сущность Shop
    /// </summary>
    public class Shop : BaseEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        [Required]
        public string Phone { get; set; }
    }
}