using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Totaly.BuldingBlocks.Core.Utils;
using Totaly.MessageBus;

namespace Totaly.Services.Identidade.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"));
        }
    }
}