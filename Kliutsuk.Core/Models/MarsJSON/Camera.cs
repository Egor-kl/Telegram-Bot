﻿namespace Kliutsuk.Core.Models
{
    /// <summary>
    /// Камера основная.
    /// </summary>
    public class Camera //TODO: Add folder 
    {
        /// <summary>
        /// ID камеры.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя камеры.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID Ровера.
        /// </summary>
        public int Rover_id { get; set; }

        /// <summary>
        /// Полное имя камеры.
        /// </summary>
        public string Full_name { get; set; }
    }
}
