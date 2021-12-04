using ETF.Meido.CrossCutting.Errors.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace ETF.Meido.CrossCutting.Errors.Implementation.Extensions
{
    public static class ErrorsServiceCollectionExtensions
    {
        public static IServiceCollection AddErrors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IErrorService, ErrorService>();
            return services;
        }
    }
}
