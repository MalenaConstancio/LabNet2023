using Entidades.LabNetPractica3;
using MVC.LabNetPractica3.Models;
using Negocio.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.LabNetPractica3.Controllers
{
    public class CategoriasController : Controller
    {
        INCategories negCat = new NCategories();
        // GET: Categories
        public ActionResult Index()
        {
            try
            {
                var lstCategorias = negCat.GetAll();
                List<CategoriaViewModel> lstCatViewModel = lstCategorias.Select(c => new CategoriaViewModel
                {
                    IdCategoria = c.CategoryID,
                    NombreCategoria = c.CategoryName,
                    DescripcionCategoria = c.Description
                }).ToList();
                return View(lstCatViewModel);
            }
            catch (Exception) {
                throw; //Cambiarlo y mostrar alert en pantalla
            }
        }

        public ActionResult Insert() {

            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriaViewModel catViewModel)
        {
            try {
                var cat = new Categories();
                cat.CategoryName = catViewModel.NombreCategoria;
                cat.Description = catViewModel.DescripcionCategoria;
                negCat.Add(cat);

                return RedirectToAction("Index");
            }
            catch (Exception) {

                throw; //Cambiarlo y mostrar alert en pantalla
            }
        }

      
    }
}