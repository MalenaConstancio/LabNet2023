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


        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try {

                Categories cat = negCat.GetOne(id);
                CategoriaModel catModel = new CategoriaModel();
                catModel.IdCategoria = cat.CategoryID;
                catModel.NombreCategoria = cat.CategoryName;
                catModel.DescripcionCategoria = cat.Description;

                return Ok(catModel);
            }catch { 

                return BadRequest("Error"); 
            }
          
        }

        [HttpPost]
        public IHttpActionResult Post(CategoriaModel catModel)
        {
            ModelState.Remove("IdCategoria");
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                try
                {

                    Categories categoria = new Categories();
                    categoria.CategoryName = catModel.NombreCategoria;
                    categoria.Description = catModel.DescripcionCategoria;
                    negCat.Add(categoria);

                    return Ok(categoria);
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPut]
        public IHttpActionResult Put(CategoriaModel catModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                try
                {

                    Categories cat = new Categories();
                    cat.CategoryID = catModel.IdCategoria;
                    cat.CategoryName = catModel.NombreCategoria;
                    cat.Description = catModel.DescripcionCategoria;

                    if (negCat.Update(cat))
                    {
                        return Ok(cat);
                    }
                    else
                    {
                        return BadRequest();
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Categories cat = new Categories();
            cat.CategoryID = id;

            if (negCat.Delete(cat))
            {
                return Ok();
            }
            else
            {
                return BadRequest("No se pueden eliminar Categorias que tengan Productos asignados");
            }


        }
    }
}
