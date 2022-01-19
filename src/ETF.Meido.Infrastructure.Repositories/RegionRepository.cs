using ETF.Meido.Domain.Entities;
using ETF.Meido.Domain.RepositoryContracts;
using ETF.Meido.Infrastructure.ServiceAgents.Contracts.Universe;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETF.Meido.Infrastructure.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly IRegionsProxy _regionsProxy;

        public RegionRepository(IRegionsProxy regionsProxy)
        {
            _regionsProxy = regionsProxy;
        }

        public async Task<IEnumerable<Region>> GetRegionsAsync()
        {
            return await _regionsProxy.GetRegionsAsync();
        }
    }
}
