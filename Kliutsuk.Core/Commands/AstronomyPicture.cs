using Kliutsuk.Core.Interfaces;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Kliutsuk.Core.Services;
using Kliutsuk.Core.Models;
using System;

namespace Kliutsuk.Core.Commands
{
    /// <inheritdoc cref="ITelegramCommand"/>
    public class AstronomyPicture : ITelegramCommand
    {
        private readonly API_Config _api;

        public AstronomyPicture(API_Config api)
        {
            if (api == null)
                throw new ArgumentNullException(nameof(api));
            else
                _api = api;
        }

        /// <inheritdoc/>
        public string Name { get; } = "/apod";

        /// <inheritdoc/> 
        public async Task Execute(Message message, ITelegramBotClient client)
        {

            var chatId = message.Chat.Id;

            var httpHandler = new HttpHandler();
            var result = await httpHandler.GetRequest("https://api.nasa.gov/","planetary/apod", _api.api_key);

            await client.SendTextMessageAsync(chatId, $"A.P.O.D - Astronomy Picture of the Day.\n====={result.title}=====\n{result.explanation}\n{result.hdurl}");
        }

        /// <inheritdoc/>
        public bool Contains(Message message) => message.Type != MessageType.Text ? false : message.Text.Contains(Name);
    }
}