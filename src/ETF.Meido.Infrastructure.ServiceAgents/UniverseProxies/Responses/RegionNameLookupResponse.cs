using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ETF.Meido.Infrastructure.ServiceAgents.UniverseProxies.Responses
{
    public class RegionNameLookupResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }
    }
}
