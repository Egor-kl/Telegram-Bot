using Flurl;
using Flurl.Http;
using Kliutsuk.Core.Models;
using System.Threading.Tasks;

namespace Kliutsuk.Core.Services
{
    /// <summary>
    /// Cтандартный HTTP Handler
    /// </summary>
    public class HttpHandler
    {
        /// <summary>
        /// Получение json файла.
        /// </summary>
        /// <param name="host">Сайт</param>
        /// <param name="path">Путь</param>
        /// <returns>json файл</returns>
        public async Task<AstronomyKeys> GetRequest(string host, string path, string apiKey)
        {
            var res = await host.AppendPathSegment(path)
                                .SetQueryParams(new {api_key = apiKey})
                                .GetJsonAsync<AstronomyKeys>();
            return res;
        }
    }
}
