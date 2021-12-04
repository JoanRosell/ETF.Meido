using ETF.Meido.Application.Services.Contracts;
using ETF.Meido.Infrastructure.Repositories.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace ETF.Meido.Application.Services.Extensions
{
    public static class ApplicationServicesServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IRegionService, RegionService>();

            services.AddRepositories();

            return services;
        }
    }
}
