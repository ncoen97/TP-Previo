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
        public List<string> ObtenerPaises()
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
            for (int i = 1; i < listaPaises.Count; i++)
            {
                lista[i] = listaPaises[i].GetName();
            }
            return lista;
        }
        public List<string> ObtenerEstados(int id)
        {
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries/"+id;
            var json = new WebClient().DownloadString(sUrlRequest);
            List<Estado> listaEstados = JsonConvert.DeserializeObject<List<Estado>>(json);
            List<string> estados = filtrarEstados(listaEstados);
            return estados;
        }
        public List<string> filtrarEstados(List<Estado> listaEstados)
        {
            List<string> lista = new List<string>();
            for (int i = 1; i < listaEstados.Count; i++)
            {
                lista[i] = listaEstados[i].GetName();
            }
            return lista;
        }
    }
}