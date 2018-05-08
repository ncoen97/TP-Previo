using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class Pais
    {
        [JsonProperty]
        string id { get; set; }
        [JsonProperty]
        string name { get; set; }
        [JsonProperty]
        string locale { get; set; }
        [JsonProperty]
        string currency_id { get; set; }
        public string GetName()
        {
            return name;
        }
        public string GetId()
        {
            return id;
        }
    }
}
