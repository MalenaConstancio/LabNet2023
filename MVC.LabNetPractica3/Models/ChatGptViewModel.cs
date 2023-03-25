using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.LabNetPractica3.Models
{
    public class ChatGptViewModel
    {
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

        public List<string> Chat { get; set; }
    }
}