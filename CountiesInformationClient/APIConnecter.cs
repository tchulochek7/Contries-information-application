using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountiesInformationClient.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DatabaseClient
{
    class APIConnecter
    {
        private HttpClient client;

        private City city;
        private Region region;
        private Country country;

        public APIConnecter(HttpClient clientF)
        {
            client = clientF;
        }

        private async Task<City> GetCityAsynk(string name)
        {
            city = null;
            var response = await client.GetAsync($"api/Cities/name/{name}");

            if (response.IsSuccessStatusCode)
            {
                city = await response.Content.ReadAsAsync<City>();
            }

            return city;
        }

        private async Task CreateCityAsynk(City city)
        {
            var response = await client.PostAsJsonAsync("api/Cities", city);
            response.EnsureSuccessStatusCode();
        }

        private async Task<Region> GetRegionAsynk(string name)
        {
            region = null;
            var response = await client.GetAsync($"api/Regions/name/{name}");

            if (response.IsSuccessStatusCode)
            {
                region = await response.Content.ReadAsAsync<Region>();
            }

            return region;
        }

        private async Task CreateRegionAsynk(Region region)
        {
            var response = await client.PostAsJsonAsync("api/Regions/", region);
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            List<Country> listCountries = null;
            var response = await client.GetAsync("api/Countries");

            if (response.IsSuccessStatusCode)
            {
                listCountries = await response.Content.ReadAsAsync<List<Country>>();
            }
            return listCountries;
        }

        private async Task<Country> GetCountryAsynk(string code)
        {
            country = null;
            var response = await client.GetAsync($"api/Countries/code/{code}");

            if (response.IsSuccessStatusCode)
            {
                country = await response.Content.ReadAsAsync<Country>();
            }

            return country;
        }

        private async Task CreateCountryAsynk(Country country)
        {
            var response = await client.PostAsJsonAsync("api/Countries", country);
            response.EnsureSuccessStatusCode();
        }

        private async Task UpdateCountryAsync(Country Country)
        {
            var response = await client.PutAsJsonAsync($"api/Countries/{Country.Id}", Country);
            response.EnsureSuccessStatusCode();
        }

        public string AddCountryInformation(CountryInformation countryFromAPI)
        {
            city = GetCity(countryFromAPI);

            if(city == null)
            {
                return "City not found!";
            }

            region = GetRegion(countryFromAPI);

            if (region == null)
            {
                return "Region not found!";
            }

            string message = AddCountry(city, region, countryFromAPI);

            return message;
        }

        private City GetCity(CountryInformation countryFromAPI)
        {
            city = Task.Run(() => GetCityAsynk(countryFromAPI.Capital)).Result;

            if (city == null)
            {
                city = new City();
                city.Title = countryFromAPI.Capital;

                try
                {
                    Task.Run(() => CreateCityAsynk(city)).Wait();
                }
                catch (Exception)
                {
                    return null;
                }

                city = Task.Run(() => GetCityAsynk(countryFromAPI.Capital)).Result;
            }

            return city;
        }

        private Region GetRegion(CountryInformation countryFromAPI)
        {
            region = Task.Run(() => GetRegionAsynk(countryFromAPI.Region)).Result;

            if (region == null)
            {
                region = new Region();
                region.Title = countryFromAPI.Region;

                try
                {
                    Task.Run(() => CreateRegionAsynk(region)).Wait();
                }
                catch (Exception)
                {
                    return null;
                }

                region = Task.Run(() => GetRegionAsynk(countryFromAPI.Region)).Result;
            }

            return region;
        }

        private string AddCountry(City city, Region region, CountryInformation countryFromAPI)
        {
            country = Task.Run(() => GetCountryAsynk(countryFromAPI.Code)).Result;

            if (country == null)
            {
                country = new Country();
                FillInCountry(country, city, region, countryFromAPI);

                try
                {
                    Task.Run(() => CreateCountryAsynk(country)).Wait();
                }
                catch (Exception)
                {
                    return "Unable to create Country!";
                }

                return "New country added.";
            }
            else
            {
                FillInCountry(country, city, region, countryFromAPI);

                try
                {
                    Task.Run(() => UpdateCountryAsync(country)).Wait();
                }
                catch (Exception)
                {
                    return "Unable to update Country!";
                }

                return "Country updated.";
            }
        }

        private void FillInCountry(Country country, City city, Region region, CountryInformation countryFromAPI)
        {
            country.Title = countryFromAPI.Title;
            country.Code = countryFromAPI.Code;
            country.CapitalId = city.Id;
            country.Area = (double)countryFromAPI.Area;
            country.Population = (int)countryFromAPI.Population;
            country.RegionId = region.Id;
        }
    }
}
