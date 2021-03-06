﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TP_Previo_2.Models
{
    public class SubmitViewModel : ApplicationDbContext
    {
        [Required]
        [Display(Name = "PaisSeleccionado")]
        public string PaisSeleccionado { get; set; }
        /*[Required]
        [Display(Name = "EstadoSeleccionado")]
        public string EstadoSeleccionado { get; set; }

        public void insertarPais(string pais)
        {
            AspNetUsers;
        }*/
    }
    public class SubmitViewModel2 : ApplicationDbContext
    {
        [Required]
        [Display(Name = "EstadoSeleccionado")]
        public string EstadoSeleccionado { get; set; }
    }
}