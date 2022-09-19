using Totaly.Services.Carrinho.API.Data;
using Totaly.WebApi.Core.Usuario;

namespace Totaly.Services.Carrinho.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();
            services.AddScoped<CarrinhoContext>();

            string teste = null;
            string? ss;
        }
    }
}