using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_Previo_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public ActionResult Censo()
        {
            List<string> ListaDeEstados = new List<string>();
            List<string> ListaDePaises = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(ListaDePaises.Contains(R.EnglishName)))
                {
                    ListaDePaises.Add(R.EnglishName);
                }
            }

            ListaDePaises.Sort();
            ViewBag.ListaDePaises = ListaDePaises;
            ViewBag.ListaDeEstados = ListaDeEstados;

            ViewBag.Message = "Ingrese su lugar de residencia";

            return View();
        }
    }
}