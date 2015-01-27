using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class CoordinatesData
    {
        [DataMember(Name = "lat")]
        public double Latitude { get; set; }

        [DataMember(Name = "lon")]
        public double Longitude { get; set; }
    }
}
