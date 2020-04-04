using System.Collections.Generic;

namespace Entites
{
    /// <summary>
    /// HASP-ключ.
    /// </summary>
    public class HaspKey
    {
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
        public List<Feature> FeaturesKeys { get; set; }
        /// <summary>
        /// Компания пользователь.
        /// </summary>
        public List<Company> Company { get; set; }
        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        public string AddInfo { get; set; }
    }
}
