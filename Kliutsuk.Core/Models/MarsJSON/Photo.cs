namespace Kliutsuk.Core.Models
{
    /// <summary>
    /// Фотографии.
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// ID Фото.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// На какой sol была сделана фотография.
        /// </summary>
        public int Sol { get; set; }

        /// <summary>
        /// Какая камера сделала.
        /// </summary>
        public Camera Camera { get; set; }
        
        /// <summary>
        /// Ссылка на фото.
        /// </summary>
        public string Img_src { get; set; }

        /// <summary>
        /// Земная дата, когда эта фотография была сделана.
        /// </summary>
        public string Earth_date { get; set; }

        /// <summary>
        /// Какой ровер сделал это фото.
        /// </summary>
        public Rover Rover { get; set; }
    }
}
