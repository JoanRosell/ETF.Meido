using ETF.Meido.Infrastructure.ServiceAgents.Contracts.Universe;
using ETF.Meido.Infrastructure.ServiceAgents.Universe;
using Microsoft.Extensions.DependencyInjection;

namespace ETF.Meido.Infrastructure.ServiceAgents.Extensions
{
    public static class ServiceAgentsServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceAgents(this IServiceCollection services)
        {
            services.AddHttpClient<IRegionsProxy, RegionsProxy>(client =>
            {
                client.BaseAddress = new System.Uri("https://esi.evetech.net/latest/universe/");
            });

            return services;
        }
    }
}
