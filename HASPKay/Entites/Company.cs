using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Компания.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } 
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Телефон.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Контакное лицо.
        /// </summary>
        public string ContactPerson { get; set; }
        /// <summary>
        /// HASP-ключ компании.
        /// </summary>
        public List<HaspKey> HaspKeys { get; set; }
    }
}