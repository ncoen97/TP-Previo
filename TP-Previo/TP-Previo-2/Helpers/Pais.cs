using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Helpers
{
    public class Pais
    {
        string id{ get; set; }
        string name{ get; set; }
        string locale{ get; set; }
        string currency_id{ get; set; }
        public string GetName(){
            return name;
        }
    }
}
