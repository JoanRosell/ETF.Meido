using ETF.Meido.Domain.RepositoryContracts;
using ETF.Meido.Infrastructure.ServiceAgents.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETF.Meido.Infrastructure.Repositories.Extensions
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRegionRepository, RegionRepository>();
            services.AddServiceAgents();

            return services;
        }
    }
}
