﻿namespace Entites
{
    /// <summary>
    /// Компания.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }
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
    }
}
