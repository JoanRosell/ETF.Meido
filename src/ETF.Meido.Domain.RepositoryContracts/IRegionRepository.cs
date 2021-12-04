using ETF.Meido.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETF.Meido.Domain.RepositoryContracts
{
    public interface IRegionRepository
    {
        public Task<IEnumerable<Region>> GetRegionsAsync();
    }
}
