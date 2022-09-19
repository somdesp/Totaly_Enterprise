using FluentValidation.Results;
using MediatR;
using Totaly.BuldingBlocks.Core.Mediator;
using Totaly.Services.Clientes.API.Application.Commands;
using Totaly.Services.Clientes.API.Application.Events;
using Totaly.Services.Clientes.API.Data;
using Totaly.Services.Clientes.API.Data.Repository;
using Totaly.Services.Clientes.API.Models;

namespace Totaly.Services.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(MediatorHandler));

            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();

        }
    }
}