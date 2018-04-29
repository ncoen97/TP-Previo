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
            List<Pais> listaPaises = JsonConvert.DeserializeObject<IEnumerable<Pais>>(json).ToList();
            List<string> paises = filtrarPaises(listaPaises);
            //List<string> paises = new List<string>(new string[] { "Arg", "Chile", "Uru" });
            return paises;
        }
        public List<string> filtrarPaises(List<Pais> listaPaises)
        {
            List<string> lista = new List<string>(listaPaises.Count);
            for (int i = 0; i < listaPaises.Count; i++)
            {
                lista.Add(listaPaises[i].GetName());
            }
            return lista;
        }
        
        public List<string> ObtenerEstados(string id)
        {
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries/" + id;
            var json = new WebClient().DownloadString(sUrlRequest);
            //           List<Estado> listaEstados = JsonConvert.DeserializeObject<List<Estado>>(json);
            //  List<Pais> listaEstados = JsonConvert.DeserializeObject<IEnumerable<Pais>>(json).ToList();
            //   List<string> estados = filtrarPaises(listaEstados);
            List<string> estados = new List<string>(new string[] { "BsAs", "Caba", "Cordoba" });
            return estados;
        }
        public List<string> filtrarEstados(List<Estado> listaEstados)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < listaEstados.Count; i++)
            {
                lista[i] = listaEstados[i].GetName();
            }
            return lista;
        }
    }
}
