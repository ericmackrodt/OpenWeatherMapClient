using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    public interface IOpenWeatherMapClient
    {
        Task<CurrentWeatherData> GetWeather(string query, Unit unit = Unit.Imperial);
        Task<CurrentWeatherData> GetWeather(int id, Unit unit = Unit.Imperial);
        Task<CurrentWeatherData> GetWeather(double lat, double lng, Unit unit = Unit.Imperial);
    }
}
