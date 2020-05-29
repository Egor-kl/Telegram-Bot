using Flurl;
using Flurl.Http;
using Kliutsuk.Core.Models;
using System;
using System.Threading.Tasks;

namespace Kliutsuk.Core.Services
{
    /// <summary>
    /// HTTP Handler для привязанный к команде Mars.
    /// </summary>
    public class HttpHandlerForMarsPhotos
    {
        /// <summary>
        /// Get запрос на получение JSON файла с фотографиями.
        /// </summary>
        /// <param name="host">Сайт</param>
        /// <param name="path">Путь</param>
        /// <returns>json list с фотографиями</returns>
        public async Task<RootPhotos> GetRequest(string host, string path, string apiKey)
        {
            DateTime dateTime = DateTime.UtcNow.AddDays(-1);
            var date = dateTime.ToString("yyyy-mm-dd");

            var res = await host.AppendPathSegment(path)
                                .SetQueryParams(new {earth_date = "2020-5-21", api_key = apiKey })
                                .GetJsonAsync<RootPhotos>();
            return res;
        }
    }
}
