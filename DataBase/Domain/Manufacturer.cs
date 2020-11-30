
using System.ComponentModel.DataAnnotations;

namespace DataBase.Domain
{
    /// <summary>
    /// сущность Manufacturer
    /// </summary>
    public class Manufacturer : BaseEntity
    {

        /// <summary>
        /// Имя марки
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public int Year { get; set; }

        public override string ToString()
        {
            return "Наименование "+ Name + "Год выпуска " + Year.ToString();
        }

    }
}