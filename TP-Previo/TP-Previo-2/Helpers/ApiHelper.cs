﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace TP_Previo_2.Helpers
{
    public class ApiHelper
    {
        public void EscribirLog(string Usuario)
        {
            DateTime Tiempo = DateTime.Now;
            List<Log> Logs = ObtenerLogs();
            Logs.Add(new Log() { Usuario = Usuario, LogTime = Tiempo.ToString() });
            string json = JsonConvert.SerializeObject(Logs.ToArray(), Formatting.Indented);
            System.IO.File.WriteAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "Helpers/Log.txt"), json);
        }
        public List<Log> ObtenerLogs()
        {
            var json = File.ReadAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "Helpers/Log.txt"));
            var jsonLogs = JsonConvert.DeserializeObject<List<LogJson>>(json);
            List<Log> listaLogs = new List<Log>(jsonLogs.Count);
            for (int i = 0; i < jsonLogs.Count; i++)
            {
                listaLogs.Add(new Log() { Usuario = jsonLogs[i].GetUsuario(), LogTime = jsonLogs[i].GetLog() });
            }
            return listaLogs;
        }
        public List<string> ObtenerPaises()
        {
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries";
            var json = new WebClient().DownloadString(sUrlRequest);
            List<Pais> listaPaises = JsonConvert.DeserializeObject<List<Pais>>(json);
         //   List<Pais> listaPaises = JsonConvert.DeserializeObject<IEnumerable<Pais>>(json).ToList();
            List<string> paises = FiltrarPaises(listaPaises);
            //List<string> paises = new List<string>(new string[] { "Arg", "Chile", "Uru" });
            return paises;
        }
        public List<string> FiltrarPaises(List<Pais> listaPaises)
        {
            List<string> lista = new List<string>(listaPaises.Count);
            for (int i = 0; i < listaPaises.Count; i++)
            {
                lista.Add(listaPaises[i].GetName());
            }
            return lista;
        }

        public List<string> ObtenerEstados(string PaisNombre)
        {
            string id = EncontrarPais(PaisNombre);
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries/" + id;
            var json = new WebClient().DownloadString(sUrlRequest);
            PaisUnitario Pais = JsonConvert.DeserializeObject<PaisUnitario>(json);
            List<string> estados = FiltrarEstados(Pais);
      //   List<string> estados = new List<string>(new string[] { "BsAs", "Caba", "Cordoba" });
            return estados;
        }
        public String EncontrarPais(String PaisNombre)
        {
            string id = null;
            string sUrlRequest = "https://api.mercadolibre.com/classified_locations/countries";
            var json = new WebClient().DownloadString(sUrlRequest);
            List<Pais> listaPaises = JsonConvert.DeserializeObject<List<Pais>>(json);
            for (int i = 0; i < listaPaises.Count; i++)
            {
                if(listaPaises[i].GetName() == PaisNombre)
                {
                    id = listaPaises[i].GetId();
                }
            }
            return id;
        }
        public List<string> FiltrarEstados(PaisUnitario Pais)
        {

            List<string> lista = new List<string>();
            List<State> ListaDeEstados = Pais.getStates().ToList();
            for (int i = 0; i < ListaDeEstados.Count; i++)
            {
                lista.Add(ListaDeEstados[i].getName());
            }
            return lista;
        }
    }
}
