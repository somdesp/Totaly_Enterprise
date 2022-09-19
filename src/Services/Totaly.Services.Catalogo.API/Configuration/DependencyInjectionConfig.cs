using Microsoft.Extensions.DependencyInjection;
using Totaly.Services.Catalogo.API.Data;
using Totaly.Services.Catalogo.API.Data.Repository;
using Totaly.Services.Catalogo.API.Models;

namespace Totaly.Services.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}