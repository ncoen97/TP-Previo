﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_Previo_2.Helpers;
using TP_Previo_2.Models;
using System.Data.SqlClient;

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
            ViewBag.Message = "Login Logs:";
            ApiHelper apiHelper = new ApiHelper();
            var LogsHechos = apiHelper.ObtenerLogs();

            return View(LogsHechos);
        }

        public List<SelectListItem> ObtenerPaises()
        {
            ApiHelper apiHelper = new ApiHelper();
            List<string> ListaDePaises = new List<string>();
            ListaDePaises = apiHelper.ObtenerPaises();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = ListaDePaises.Select(x => new SelectListItem() { Value = x, Text = x }).ToList();
            return selectListItems;
        }
        public List<SelectListItem> ObtenerEstados(string id)
        {
            ApiHelper apiHelper = new ApiHelper();
            List<string> ListaDeEstados = new List<string>();
            ListaDeEstados = apiHelper.ObtenerEstados(id);
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = ListaDeEstados.Select(x => new SelectListItem() { Value = x, Text = x }).ToList();
            return selectListItems;
        }
        [Authorize]
        [HttpGet]
        public ActionResult Censo()
        {
          //  string id = "AR";
            List<string> ListaDeEstados = new List<string>();
            ViewBag.ListaDePaises = ObtenerPaises();
          //  ViewBag.ListaDeEstados = ObtenerEstados(id);

            ViewBag.Message = "Ingrese su pais de residencia";

            return View();
        }
        [HttpPost]
        public ActionResult Censo(SubmitViewModel model)
        {
            return RedirectToAction("Censo2", "Home", new { id = model.PaisSeleccionado });
        }
        [HttpGet]
        public ActionResult Censo2(string id)
        {
            ViewBag.Message = "Ingrese su estado";
            ViewBag.ListaDeEstados = ObtenerEstados(id);
            return View();
        }
        [HttpPost]
        public ActionResult Censo2(SubmitViewModel2 model, string id)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            BaseDeDatos db = new BaseDeDatos();
            string sentencia = "UPDATE dbo.AspNetUsers SET Pais = '" + id + "', Estado = '" + model.EstadoSeleccionado + "' WHERE Email = '" + user.Email + "'";

            db.ExecQuery(sentencia);
            
            return RedirectToAction("Guardar", "Home");
        }
        public ActionResult Guardar()
        {
            return View();
        }
    }
}