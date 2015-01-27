﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenWeatherMapApiClient
{
    [DataContract]
    public class MainData
    {
        [DataMember(Name = "temp")]
        public double Temperature { get; set; }

        [DataMember(Name = "pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "humidity")]
        public int Humidity { get; set; }

        [DataMember(Name = "temp_min")]
        public double MinTemperature { get; set; }

        [DataMember(Name = "temp_max")]
        public double MaxTemperature { get; set; }
    }
}
