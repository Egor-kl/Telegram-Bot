using System;
using System.Collections.Generic;
using System.Text;

namespace Kliutsuk.Core.Models
{
    /// <summary>
    /// Root для получения фоток.
    /// </summary>
    public class RootPhotos
    {
        /// <summary>
        /// Список с фотографиями.
        /// </summary>
        public List<Photo> Photos { get; set; }
    }
}
