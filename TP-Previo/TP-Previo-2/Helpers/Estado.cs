using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class Estado
    {
        string id;
        string name;
        string locale;
        string currency_id;
        char decimal_separator;
        char thousands_separator;
        string time_zone;
        GeoInformation geo_information;
        Pais[] states;
        public string GetName()
        {
            return name;
        }
    }
}