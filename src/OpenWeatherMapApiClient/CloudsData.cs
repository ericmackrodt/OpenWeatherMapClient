using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class CloudsData
    {
        [DataMember(Name = "all")]
        public int All { get; set; }
    }
}
