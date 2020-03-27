using System.Collections.Generic;

namespace Entites
{
    /// <summary>
    /// HASP-ключ.
    /// </summary>
    public class HaspKay
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер ключа.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Тип ключа.
        /// </summary>
        public string TypeKay { get; set; }
        /// <summary>
        /// Особенности
        /// </summary>
        public List<Features> FeaturesKeys { get; set; }
        /// <summary>
        /// Компания пользователь.
        /// </summary>
        public Company Company { get; set; }
    }
}
