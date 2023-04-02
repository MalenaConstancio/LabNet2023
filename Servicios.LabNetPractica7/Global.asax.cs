using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Servicios.LabNetPractica7
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "http://localhost:4200");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                //These headers are handling the "pre-flight" OPTIONS call sent by the browser
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, PUT,DELETE,GET");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "content-type");
                HttpContext.Current.Response.End();
            }
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, PUT, PATCH, GET, DELETE,OPTIONS");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", " Origin, X-Api-Key, X-Requested-With, Content-Type, Accept, Authorization");
        }
    }
}
