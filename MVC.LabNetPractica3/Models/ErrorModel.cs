using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.LabNetPractica3.Models
{
    public class ErrorModel
    {
        public string Mensaje { get; set; }
        public string InnerException { get; set; }
    }
}