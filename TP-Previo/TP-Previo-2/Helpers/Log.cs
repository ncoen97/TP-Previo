using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TP_Previo_2.Helpers
{
    public class LogJson
    {
        [JsonProperty]
        public string Usuario;
        [JsonProperty]
        string LogTime;
        public string GetUsuario()
        {
            return Usuario;
        }
        public string GetLog()
        {
            return LogTime;
        }
    }
    public class Log
    {
        public string Usuario;
        public string LogTime;
        public string GetUsuario()
        {
            return Usuario;
        }
        public string GetLog()
        {
            return LogTime;
        }
    }
}