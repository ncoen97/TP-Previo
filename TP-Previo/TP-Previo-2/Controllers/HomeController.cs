using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_Previo_2.Helpers;
using TP_Previo_2.Models;

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
            ListaDePaises = apiHelper.ObtenerPaises();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = ListaDePaises.Select(x => new SelectListItem() { Value = x, Text = x }).ToList();
            return selectListItems;
        }
        public List<SelectListItem> obtenerEstados(string id)
        {
            ApiHelper apiHelper = new ApiHelper();
            List<string> ListaDeEstados = new List<string>();
            ListaDeEstados = apiHelper.ObtenerEstados(id);
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = ListaDeEstados.Select(x => new SelectListItem() { Value = x, Text = x }).ToList();
            return selectListItems;
        }
        [Authorize]
        public ActionResult Censo()
        {
            string id = "AR";
            List<string> ListaDeEstados = new List<string>();
            ViewBag.ListaDePaises = obtenerPaises();
            ViewBag.ListaDeEstados = obtenerEstados(id);

            ViewBag.Message = "Ingrese su lugar de residencia";

            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Guardar(SubmitViewModel model)
        {

            model.PaisSeleccionado = ViewBag.Pais;
            model.EstadoSeleccionado = ViewBag.Estado;

            return View();
        }

    }
}