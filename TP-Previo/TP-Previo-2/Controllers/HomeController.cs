using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_Previo_2.Helpers;

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

        public List<SelectListItem> obtenerPaises()
        {
            ApiHelper apiHelper = new ApiHelper();
            List<string> ListaDePaises = new List<string>();
            ListaDePaises = apiHelper.obtenerPaises();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = ListaDePaises.Select(x => new SelectListItem() { Value = x, Text = x }).ToList();
            return selectListItems;
        }
        
        public ActionResult Censo()
        {
            List<string> ListaDeEstados = new List<string>();
            ViewBag.ListaDePaises = obtenerPaises();
            ViewBag.ListaDeEstados = ListaDeEstados;

            ViewBag.Message = "Ingrese su lugar de residencia";

            return View();
        }
        
    }
}