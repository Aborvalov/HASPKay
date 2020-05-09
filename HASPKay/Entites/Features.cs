﻿using System;

namespace Entities
{  /// <summary>
   /// Особенности ключа.
   /// </summary>
    public class Feature
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int FeatureId { get; set; }
        /// <summary>
        /// Номер.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Срок действия.
        /// </summary>
        public DateTime Validity { get; set; }
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