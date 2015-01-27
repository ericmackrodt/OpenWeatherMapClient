using HttpClientHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    public class OpenWeatherMapClient : IOpenWeatherMapClient
    {
        public async Task<CurrentWeatherData> GetWeather(string query, Unit unit = Unit.Imperial)
        {
            return await GetRequest<CurrentWeatherData>("weather", QueryHelper.BuildQueryString(new { q = query, units = unit.ToString().ToLower() }));
        }

        public async Task<CurrentWeatherData> GetWeather(int id, Unit unit = Unit.Imperial)
        {
            return await GetRequest<CurrentWeatherData>("weather", QueryHelper.BuildQueryString(new { id = id, units = unit.ToString().ToLower() }));
        }

        public async Task<CurrentWeatherData> GetWeather(double lat, double lon, Unit unit = Unit.Imperial)
        {
            return await GetRequest<CurrentWeatherData>("weather", QueryHelper.BuildQueryString(new { lat = lat, lon = lon, units = unit.ToString().ToLower() }));
        }

        private async Task<T> GetRequest<T>(string endpoint, string queryString)
        {
            var cli = new HttpClient();
            var data = await cli.GetAsync(QueryHelper.BuildRequestUrl(ApiConstants.BaseUrl, endpoint, queryString));
            var weatherJson = await data.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(weatherJson);
        }
    }
}
