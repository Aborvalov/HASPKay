using System.Collections.Generic;

namespace Entites
{
    /// <summary>
    /// HASP-ключ.
    /// </summary>
    public class HaspKey
    {
        public HaspKey()
        {
            this.Features = new HashSet<Feature>();
            this.Companies = new HashSet<Company>();
        }
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int HaspKeyId { get; set; }
        /// <summary>
        /// Номер ключа.
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Тип ключа.
        /// </summary>
        public TypeKey TypeKey { get; set; }
        /// <summary>
        /// Особенности
        /// </summary>
       // public List<Feature> FeaturesKeys { get; set; }
       public virtual ICollection<Feature> Features { get; private set; }

        /// <summary>
        /// Компания пользователь.
        /// </summary>
        //public List<Company> Company { get; set; }
        public virtual ICollection<Company> Companies { get; private set;}

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        public string AddInfo { get; set; }
    }
}
