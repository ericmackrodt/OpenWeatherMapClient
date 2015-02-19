using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class SnowData
    {
        [DataMember(Name = "3h")]
        public double In3h { get; set; }
    }
}
