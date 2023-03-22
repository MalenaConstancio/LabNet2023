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
            if (catViewModel.IdCategoria != 0)
            {
                try { 
                    
                    var cat = new Categories();
                    cat.CategoryID = catViewModel.IdCategoria;
                    cat.CategoryName = catViewModel.NombreCategoria;
                    cat.Description = catViewModel.DescripcionCategoria;
                    negCat.Update(cat);

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    var cat = new Categories();
                    cat.CategoryName = catViewModel.NombreCategoria;
                    cat.Description = catViewModel.DescripcionCategoria;
                    negCat.Add(cat);

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw; //Cambiarlo y mostrar alert en pantalla
                }
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var cat = new Categories();
                cat.CategoryID = id;
                negCat.Delete(cat);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw; //Cambiarlo y mostrar alert en pantalla
            }
        }

       
        public ActionResult Update(int id)
        {
            try
            {
                Categories cat = new Categories();
                cat.CategoryID = id;
                cat.CategoryName=  negCat.GetOne(cat).CategoryName;
                cat.Description = negCat.GetOne(cat).Description;
                var catViewModelEdit = new CategoriaViewModel();
                catViewModelEdit.IdCategoria = cat.CategoryID;
                catViewModelEdit.NombreCategoria = cat.CategoryName;
                catViewModelEdit.DescripcionCategoria = cat.Description;

                return View("Insert",catViewModelEdit);
            }
            catch (Exception)
            {
                throw; //Cambiarlo y mostrar alert en pantalla
            }
        }
      
    }
}