using System;

namespace Entites
{  /// <summary>
   /// Особенности ключа.
   /// </summary>
    public class Features
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Срок действия.
        /// </summary>
        public int Validity { get; set; }
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set;}
        /// <summary>
        /// Дата прошивки.
        /// </summary>
        public DateTime Firmware { get; set; }
    }
}
