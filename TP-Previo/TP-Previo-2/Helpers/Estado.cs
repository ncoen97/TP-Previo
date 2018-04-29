using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class Estado
    {
        [JsonProperty]
        string id;
        [JsonProperty]
        string name;
        [JsonProperty]
        string locale;
        [JsonProperty]
        string currency_id;
        [JsonProperty]
        char decimal_separator;
        [JsonProperty]
        char thousands_separator;
        [JsonProperty]
        string time_zone;
        [JsonProperty]
        GeoInformation geo_information;
        [JsonProperty]
        Pais[] states;
        public string GetName()
        {
            return name;
        }
    }
}