using Kliutsuk.Core.Interfaces;
using Kliutsuk.Core.Models;
using Kliutsuk.Core.Services;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Kliutsuk.Core.Commands
{
    /// <inheritdoc cref="ITelegramCommand"/>
    public class MarsRoverPhotos : ITelegramCommand
    {
        private readonly API_Config _api;

        public MarsRoverPhotos(API_Config api)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }
            else
            {
                _api = api;
            }
        }
        /// <inheritdoc/>
        public string Name { get; } = "/mars";

        /// <inheritdoc/> 
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            try
            {
                var chatId = message.Chat.Id;

                var rand = new Random();
                var httpHandler = new HttpHandlerForMarsPhotos();
                var res = await httpHandler.GetRequest("https://api.nasa.gov", "mars-photos/api/v1/rovers/curiosity/photos", _api.api_key);
                var result = res.Photos;
                for (var i = 0; i<9;i++)
                {
                    Console.WriteLine(result[i].Img_src);
                }

                await client.SendTextMessageAsync(chatId, $"This is last photo from MARS!\n {result[rand.Next(10)].Img_src} " );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request failed. Please, try again later");
            }
        }

        /// <inheritdoc/>
        public bool Contains(Message message) => message.Type != MessageType.Text ? false : message.Text.Contains(Name);
    }
}
