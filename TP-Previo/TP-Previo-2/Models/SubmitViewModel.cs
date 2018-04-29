using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Previo_2.Models
{
    public class SubmitViewModel : ApplicationDbContext
    {
        public string Pais { get; set; }
        public string Estado { get; set; }
    }
}