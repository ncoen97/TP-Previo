using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class Location
    {
        [JsonProperty]
        float latitude;
        [JsonProperty]
        float longitude;
    }
}