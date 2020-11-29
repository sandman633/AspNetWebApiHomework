
namespace DataBase.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Manufacturer : BaseEntity
    {

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Year { get; set; }

        public override string ToString()
        {
            return "Наименование "+ Name + "Год выпуска " + Year.ToString();
        }

    }
}