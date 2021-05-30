﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Activities.Conductor.Models;
using Elsa.Activities.Conductor.Options;
using Elsa.Activities.Conductor.Services;
using Microsoft.Extensions.Options;

namespace Elsa.Activities.Conductor.Providers.Commands
{
    public class OptionsCommandProvider : ICommandProvider
    {
        private readonly ConductorOptions _options;
        public OptionsCommandProvider(IOptions<ConductorOptions> options) => _options = options.Value;
        public ValueTask<IEnumerable<CommandDefinition>> GetCommandsAsync(CancellationToken cancellationToken) => new(_options.Commands);
    }
}