using Kliutsuk.Core.Commands;
using Kliutsuk.Core.Interfaces;
using Kliutsuk.Core.Models;
using Microsoft.Extensions.Options;
using System;
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
        public CommandService(IOptions<API_Config> options)
        {
            options = options ?? throw new ArgumentNullException(nameof(options));

            _commands = new List<ITelegramCommand>
            {
                new StartCommand(),
                new AstronomyPicture(options.Value),
                new MarsRoverPhotos(options.Value)
            };
        }

        /// <inheritdoc/>
        public IEnumerable<ITelegramCommand> Get() => _commands;
    }
}
