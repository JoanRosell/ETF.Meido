using ETF.Meido.CrossCutting.Errors.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace ETF.Meido.WebApi.Extensions
{
    public static class CommonServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureErrors(configuration);
            return services;
        }

        private static IServiceCollection ConfigureErrors(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Dictionary<ErrorType, Error>>(configuration.GetSection("Errors"));
            return services;
        }
    }
}
