using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class WeatherConditionData
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "main")]
        public string Main { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }
    }
}
