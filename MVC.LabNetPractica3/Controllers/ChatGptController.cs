using MVC.LabNetPractica3.Models;
using Negocio.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MVC.LabNetPractica3.Controllers
{
    public class ChatGptController : Controller
    {
        INChatGpt negChat = new NChatGpt();
        
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<ActionResult>  Index(ChatGptViewModel model)
        {
            var respuesta = await negChat.Responder(model.Pregunta);

           
                if (HttpContext.Session["chat"]==null) {

                    Dictionary<string, string> diccSession = new Dictionary<string, string>();
                    diccSession.Add(model.Pregunta,respuesta);

                    model.Chat = diccSession;
                    model.Pregunta = "";
                    HttpContext.Session["chat"] = model.Chat;

                }
                else 
                {
                    var diccSession = (Dictionary<string, string>)HttpContext.Session["chat"];
                    diccSession.Add(model.Pregunta,respuesta);
                    model.Chat  = diccSession;
                   
                    HttpContext.Session["chat"] = model.Chat;
                }
                
            return View(model);
        }

        public ActionResult Limpiar(ChatGptViewModel model) {

            HttpContext.Session["chat"] = null;
            model.Pregunta = "";
            model.Respuesta = "";
            model.Chat = (Dictionary<string, string>)HttpContext.Session["chat"];

            return View("Index",model);
        }
    }
}