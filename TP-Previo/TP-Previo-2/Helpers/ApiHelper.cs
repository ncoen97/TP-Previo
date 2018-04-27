using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace TP_Previo_2.Helpers
{
    public class ApiHelper
    {
        public List<string> obtenerPaises()
        {
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries";
            var json = new WebClient().DownloadString(sUrlRequest);
            List<Pais> listaPaises = JsonConvert.DeserializeObject<List<Pais>>(json);
            List<string> paises = filtrarPaises(listaPaises);
            return paises;
        }
        public List<string> filtrarPaises(List<Pais> listaPaises)
        {
            List<string> lista = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                lista[i] = listaPaises[i].GetName();
            }
            return lista;
        }
    }
}