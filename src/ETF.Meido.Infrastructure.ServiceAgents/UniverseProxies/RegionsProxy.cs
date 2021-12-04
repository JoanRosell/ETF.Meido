using ETF.Meido.Domain.Entities;
using ETF.Meido.Infrastructure.ServiceAgents.Contracts.Universe;
using ETF.Meido.Infrastructure.ServiceAgents.UniverseProxies.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ETF.Meido.Infrastructure.ServiceAgents.Universe
{
    public class RegionsProxy : IRegionsProxy
    {
        private readonly HttpClient _httpClient;

        public RegionsProxy(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Region>> GetRegionsAsync()
        {
            var getRegionIdsResponse = await _httpClient.GetAsync("regions");
            getRegionIdsResponse.EnsureSuccessStatusCode();

            var regionIds = await JsonSerializer.DeserializeAsync<IEnumerable<int>>(await getRegionIdsResponse.Content.ReadAsStreamAsync());

            var requestBody = new StringContent(JsonSerializer.Serialize(regionIds), Encoding.UTF8, Application.Json);

            var regionNameLookupResponse = await _httpClient.PostAsync("names", requestBody);
            regionNameLookupResponse.EnsureSuccessStatusCode();

            var regionData = await JsonSerializer.DeserializeAsync<IEnumerable<RegionNameLookupResponse>>(await regionNameLookupResponse.Content.ReadAsStreamAsync());

            var regions = new List<Region>();
            foreach (var region in regionData)
            {
                regions.Add(new Region
                {
                    Id = region.Id,
                    Name = region.Name,
                });
            }

            return regions;
        }
    }
}
