using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapApiClient
{
    public enum Units
    {
        Metric = 0,
        Imperial = 1
    }

    public enum WeatherConditionCode
    {
        //THUNDERSTORM
        ThunderstormWithLightRain       = 200,
        ThunderstormWithRain            = 201,
        ThunderstormWithHeavyRain       = 202,
        LightThunderstorm               = 210,
        Thunderstorm                    = 211,
        HeavyThunderstorm               = 212,
        RaggedThunderstorm              = 221,
        ThunderstormWithLightDrizzle    = 230,
        ThunderstormWithDrizzle         = 231,
        ThunderstormWithHeavyDrizzle    = 232,

        //DRIZZLE,
        LightIntensityDrizzle           = 300,
        Drizzle                         = 301,
        HeavyIntensityDrizzle           = 302,
        LightIntensityDrizzleRain       = 310,
        DrizzleRain                     = 311,
        HeavyIntensityDrizzleRain       = 312,
        ShowerRainAndDrizzle            = 313,
        HeavyShowerRainAndDrizzle       = 314,
        ShowerDrizzle                   = 321,

        //RAIN
        LightRain                       = 500,
        ModerateRain                    = 501,
        HeavyIntensityRain              = 502,
        VeryHeavyRain                   = 503,
        ExtremeRain                     = 504,
        FreezingRain                    = 511,
        LightIntensityShowerRain        = 520,
        ShowerRain                      = 521,
        HeavyIntensityShowerRain        = 522,
        RaggedShowerRain                = 531,
        
        //SNOW
        LightSnow                       = 600,
        Snow                            = 601,
        HeavySnow                       = 602,
        Sleet                           = 611,
        ShowerSleet                     = 612,
        LightRainAndSnow                = 615,
        RainAndSnow                     = 616,
        LightShowerSnow                 = 620,
        ShowerSnow                      = 621,
        HeavyShowerSnow                 = 622,
        
        //ATMOSPHERE
        Mist                            = 701,
        Smoke                           = 711,
        Haze                            = 721,
        SandDustWhirls                  = 731,
        Fog                             = 741,
        Sand                            = 751,
        Dust                            = 761,
        VolcanicAsh                     = 762,
        Squalls                         = 771,
        Tornado                         = 781,
        
        //CLOUDS
        ClearSky                        = 800,
        FewClouds                       = 801,
        ScatteredClouds                 = 802,
        BrokenClouds                    = 803,
        OvercastClouds                  = 804,
        
        //EXTREME
        Tornado_Extreme                 = 900,
        TropicalStorm                   = 901,
        Hurricane                       = 902,
        Cold                            = 903,
        Hot                             = 904,
        Windy                           = 905,
        Hail                            = 906,

        //ADDITIONAL
        Calm                            = 951,
        LightBreeze                     = 952,
        GentleBreeze                    = 953,
        ModerateBreeze                  = 954,
        FreshBreeze                     = 955,
        StrongBreeze                    = 956,
        HighWindNearGale                = 957,
        Gale                            = 958,
        SevereGale                      = 959,
        Storm                           = 960,
        ViolentStorm                    = 961,
        Hurricane_Additional            = 962
    }
}
