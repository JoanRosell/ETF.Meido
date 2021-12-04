using ETF.Meido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETF.Meido.Infrastructure.ServiceAgents.Contracts.Universe
{
    public interface IRegionsProxy
    {
        public Task<IEnumerable<Region>> GetRegionsAsync();
    }
}
