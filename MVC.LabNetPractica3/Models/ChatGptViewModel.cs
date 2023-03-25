using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.LabNetPractica3.Models
{
    public class ChatGptViewModel
    {
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

        //public List<string> Chat { get; set; }
        public Dictionary<string, string> Chat { get; set; }
    }
}