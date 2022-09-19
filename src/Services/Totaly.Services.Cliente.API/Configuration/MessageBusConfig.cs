using Totaly.BuldingBlocks.Core.Utils;
using Totaly.MessageBus;
using Totaly.Services.Clientes.API.Services;

namespace Totaly.Services.Clientes.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}