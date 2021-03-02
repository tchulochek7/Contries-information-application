using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountiesInformationClient.Models
{
    public class CountryInformation
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("numericCode")]
        public string Code { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("area")]
        public double? Area { get; set; }

        [JsonProperty("population")]
        public int? Population { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
