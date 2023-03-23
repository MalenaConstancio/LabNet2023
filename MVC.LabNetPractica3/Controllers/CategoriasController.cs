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
            catch (Exception ex) {
                ErrorModel errModel = new ErrorModel();
                errModel.Mensaje = ex.Message;
                errModel.InnerException = ex.InnerException.Message;
                return View("Error",errModel);
            }
        }


       
        [HttpPost]
        public ActionResult Insert(CategoriaViewModel catViewModel)
        {
            if (catViewModel.IdCategoria != 0)
            {
                try { 
                    if(ModelState.IsValid){ 
                        var cat = new Categories();
                        cat.CategoryID = catViewModel.IdCategoria;
                        cat.CategoryName = catViewModel.NombreCategoria;
                        cat.Description = catViewModel.DescripcionCategoria;
                        negCat.Update(cat);
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ErrorModel errModel = new ErrorModel();
                    errModel.Mensaje = ex.Message;
                    errModel.InnerException = ex.InnerException.InnerException.Message;
                    return View("Error", errModel);
                }
            }
            else
            {              
                try
                {
                    ModelState.Remove("IdCategoria");
                    if (ModelState.IsValid)
                    {
                        var cat = new Categories();
                        cat.CategoryName = catViewModel.NombreCategoria;
                        cat.Description = catViewModel.DescripcionCategoria;
                        negCat.Add(cat);
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ErrorModel errModel = new ErrorModel();
                    errModel.Mensaje = ex.Message;
                    errModel.InnerException = ex.InnerException.InnerException.Message;
                    return View("Error", errModel);

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
            catch (Exception ex)
            {
                ErrorModel errModel = new ErrorModel();
                errModel.Mensaje = ex.Message;
                errModel.InnerException = ex.InnerException.InnerException.Message;
                return View("Error", errModel);
            }
        }

        public ActionResult Insert()
        {

            return View();
        }

        public ActionResult Update(int id)
        {
            try
            {
                Categories cat = new Categories();
                cat =  negCat.GetOne(id);
                
                var catViewModelEdit = new CategoriaViewModel();
                catViewModelEdit.IdCategoria = cat.CategoryID;
                catViewModelEdit.NombreCategoria = cat.CategoryName;
                catViewModelEdit.DescripcionCategoria = cat.Description;

                return View("Insert",catViewModelEdit);
            }
            catch (Exception ex)
            {
                ErrorModel errModel = new ErrorModel();
                errModel.Mensaje = ex.Message;
                errModel.InnerException = ex.InnerException.InnerException.Message;
                return View("Error", errModel);
            }
        }
      
    }
}