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
            System.Web.HttpContext.Current.Session["chat"] = model.Chat;
            var respuesta = await negChat.Responder(model.Pregunta);

            model.Respuesta = respuesta;

            if (model.Chat != null) { 
                model.Chat.Add(model.Respuesta);
            }
            else
            {
                List<string> chat = new List<string>();
                chat.Add(respuesta);
                model.Chat = chat;
            }

            return View(model);
        }

        public ActionResult Limpiar(ChatGptViewModel model) {

            List<string> chat = new List<string>();
            model.Pregunta = "";

            return View("Index",model);
        }
    }
}