using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    public interface IOpenWeatherMapSettings
    {
        string ApiKey { get; }
    }
}
