using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class WindData
    {
        [DataMember(Name = "speed")]
        public double Speed { get; set; }

        [DataMember(Name = "deg")]
        public double Direction { get; set; }
    }
}
