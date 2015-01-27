using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class CurrentWeatherData
    {
        [DataMember(Name = "dt")]
        public string Dt { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "coord")]
        public CoordinatesData Coordinates { get; set; }

        [DataMember(Name = "sys")]
        public SysData Sys { get; set; }

        [DataMember(Name = "weather")]
        public WeatherConditionData[] Weather { get; set; }

        [DataMember(Name = "base")]
        public string Base { get; set; }

        [DataMember(Name = "main")]
        public MainData Main { get; set; }

        [DataMember(Name = "wind")]
        public WindData Wind { get; set; }

        [DataMember(Name = "clouds")]
        public CloudsData Clouds { get; set; }

        [DataMember(Name = "rain")]
        public RainData Rain { get; set; }

        [DataMember(Name = "snow")]
        public SnowData Snow { get; set; }
    }
}
