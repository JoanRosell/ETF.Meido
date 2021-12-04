using ETF.Meido.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETF.Meido.Application.Services.Contracts
{
    public interface IRegionService
    {
        public Task<IEnumerable<Region>> GetRegions();
    }
}
