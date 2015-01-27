using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class SysData
    {
        [DataMember(Name = "message")]
        public double Message { get; set; }
        
        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "sunrise")]
        public long Sunrise { get; set; }

        [DataMember(Name = "sunset")]
        public long Sunset { get; set; }
    }
}
