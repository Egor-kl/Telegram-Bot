using Kliutsuk.Core.Interfaces;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Kliutsuk.Core.Commands
{
    /// <inheritdoc cref="ITelegramCommand"/>
    public class StartCommand : ITelegramCommand
    {
        /// <inheritdoc/>
        public string Name { get; } = "/start";

        /// <inheritdoc/>
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            try
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId, $"Hello! This bot allows you to see the beauty of the universe. \nList of available commands: \n" +
                    $"/apod - This command shows you every day a new interesting post from one of NASA's most popular sites.\n" +
                    $"/mars - This command allows you to see the last photo from Mars.");
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
