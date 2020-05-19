using Kliutsuk.Core.Commands;
using Kliutsuk.Core.Interfaces;
using System.Collections.Generic;

namespace Kliutsuk.Core.Services
{
    /// <inheritdoc cref="ICommandService"/>
    public class CommandService : ICommandService
    {
        private readonly IEnumerable<ITelegramCommand> _commands;

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandService()
        {
            _commands = new List<ITelegramCommand>
            {
                new StartCommand(),
                //new AboutCommand(),
                //new LinkCommand()
            };
        }

        /// <inheritdoc/>
        public IEnumerable<ITelegramCommand> Get() => _commands;
    }
}
