using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// HASP-ключ.
    /// </summary>
    public class HaspKey
    {
        public HaspKey()
        {
            this.Features = new List<Feature>();
            this.Companies = new List<Company>();
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
        public List<Feature> Features { get; set; }
      // public ICollection<Feature> Features { get; set; }

        /// <summary>
        /// Компания пользователь.
        /// </summary>
        public List<Company> Companies { get; set; }
       // public ICollection<Company> Companies { get; set;}

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        public string AddInfo { get; set; }
    }
}
