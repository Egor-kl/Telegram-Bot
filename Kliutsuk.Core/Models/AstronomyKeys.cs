using System;

namespace Kliutsuk.Core.Models
{
    /// <summary>
    /// GET JSON запрос на одноимённую комманду.
    /// </summary>
    public class AstronomyKeys
    {
        /// <summary>
        /// Кто написал.
        /// </summary>
        public string copyright { get; set; }

        /// <summary>
        /// Дата написания.
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// Текст.
        /// </summary>
        public string explanation { get; set; }

        /// <summary>
        /// HD ссылка.
        /// </summary>
        public string hdurl { get; set; }

        /// <summary>
        /// Тип вложенного объекта.
        /// </summary>
        public string media_type { get; set; }

        /// <summary>
        /// Версия.
        /// </summary>
        public string service_version { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        public string title{ get; set; }

        /// <summary>
        /// Обычная ссылка.
        /// </summary>
        public string url { get; set; }
    }
}
