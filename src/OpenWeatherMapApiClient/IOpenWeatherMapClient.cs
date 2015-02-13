using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    public interface IOpenWeatherMapClient
    {
        Task<CurrentWeatherData> GetWeather(string query, Units unit = Units.Imperial);
        Task<CurrentWeatherData> GetWeather(int id, Units unit = Units.Imperial);
        Task<CurrentWeatherData> GetWeather(double lat, double lng, Units unit = Units.Imperial);
    }
}
