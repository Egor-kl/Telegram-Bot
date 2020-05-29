using System.Collections.Generic;

namespace Kliutsuk.Core.Models
{
    /// <summary>
    /// Всё про ровер.
    /// </summary>
    public class Rover
    {
        /// <summary>
        /// ID Ровера.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя Ровера.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата посадки Ровера.
        /// </summary>
        public string Landing_date { get; set; }

        /// <summary>
        /// Дата запуска Ровера.
        /// </summary>
        public string launch_date { get; set; }

        /// <summary>
        /// Статус Ровера.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Последний SOL с фотографией.
        /// </summary>
        public int Max_sol { get; set; }

        /// <summary>
        /// Последний сол когда он откликался/откликается.
        /// </summary>
        public string Max_date { get; set; }

        /// <summary>
        /// Не знаю что за параметр, так и не понял. НЕ ИСПОЛЬЗОВАТЬ!
        /// </summary>
        public int Total_photos { get; set; }

        /// <summary>
        /// Список с фотками.
        /// </summary>
        public List<Camera2> Cameras { get; set; }
    }
}
