using ETF.Meido.Application.Services.Contracts;
using ETF.Meido.Domain.Entities;
using ETF.Meido.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETF.Meido.Application.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;

        public RegionService(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public async Task<IEnumerable<Region>> GetRegions()
        {
            return await _regionRepository.GetRegionsAsync();
        }
    }
}
