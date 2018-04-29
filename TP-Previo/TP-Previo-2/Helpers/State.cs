using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class State
    {
        [JsonProperty]
        string id;
        [JsonProperty]
        string name;
        public string getName()
        {
            return name;
        }
    }
}