using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountiesInformationClient.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DatabaseClient
{
    class APIConnecterCI
    {
        private HttpClient clientCI;

        private CountryInformation countryFromAPI;

        public APIConnecterCI(HttpClient clientCIF)
        {
            clientCI = clientCIF;
        }

        public CountryInformation GetCountryInformation(string countryName)
        {
            string countryResponse = Task.Run(() => GetCountryInformationAsynk(countryName)).Result;

            if (countryResponse != null)
            {
                try
                {
                    countryFromAPI = JsonConvert.DeserializeObject<List<CountryInformation>>(countryResponse)[0];
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return countryFromAPI;
        }

        private async Task<string> GetCountryInformationAsynk(string countryName)
        {
            string response = null;

            try
            {
                response = await clientCI.GetStringAsync($"rest/v2/name/{countryName}");
            }
            catch (Exception)
            {
                return null;
            }

            return response;
        }
    }
}
