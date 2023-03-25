using Negocio.LabNetPractica3;
using Entidades.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVC.LabNetPractica3.Models;

namespace Servicios.LabNetPractica3.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        INCategories negCat = new NCategories();

        public IHttpActionResult Get()
        {
            try
            {
                List<Categories> lstCategorias = negCat.GetAll();

                List<CategoriaViewModel> lstCategoriasViewModel = lstCategorias.Select(c => new CategoriaViewModel
                {
                    IdCategoria = c.CategoryID,
                    NombreCategoria=c.CategoryName,
                    DescripcionCategoria=c.Description
                }).ToList();
                return Ok(lstCategoriasViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
