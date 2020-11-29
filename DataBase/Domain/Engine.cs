

using System.ComponentModel.DataAnnotations;

namespace DataBase.Domain
{
    /// <summary>
    /// Описание сущности двигатель
    /// TODO: Написать комментарии
    /// </summary>
    public class Engine : BaseEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(2500)]
        public string Description { get; set; }
        public override string ToString()
        {
            return Name + " " + Type + " " + Power.ToString() + " " + Description;
        }
    }
}
