using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class PaisUnitario
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
        string decimal_separator;
        [JsonProperty]
        string thousands_separator;
        [JsonProperty]
        string time_zone;
        [JsonIgnore]
        string geo_information;
        [JsonProperty]
        State[] states;
        public State[] getStates()
        {
            return states;
        }
        public string GetName()
        {
            return name;
        }
    }
}