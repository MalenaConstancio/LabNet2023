using Entidades.LabNetPractica3;
using Negocio.LabNetPractica3;
using Servicios.LabNetPractica7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicios.LabNetPractica7.Controllers
{
    public class CategoriesController : ApiController
    {
        INCategories negCat = new NCategories();

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<Categories> categorias = negCat.GetAll();
                List<CategoriaModel> categoriasModel = categorias.Select(c => new CategoriaModel
                {
                    IdCategoria=c.CategoryID,
                    NombreCategoria=c.CategoryName,
                    DescripcionCategoria=c.Description
                    
                }).ToList();
                return Ok(categoriasModel);
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
