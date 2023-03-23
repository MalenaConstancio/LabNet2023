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
    public class ProveedoresController : Controller
    {

        IProveedor negProv = new NProveedor();
        public ActionResult Index()
        {
            try
            {
                var lstProveedores = negProv.GetAll();
                List<ProveedorViewModel> lstProvViewModel = lstProveedores.Select(p => new ProveedorViewModel
                {
                    IdProveedor=p.SupplierID,
                    NombreProveedor=p.CompanyName,
                    CiudadProveedor=p.City,
                    TelefonoProveedor=p.Phone
                }).ToList();
                return View(lstProvViewModel);
            }
            catch (Exception ex)
            {
                ErrorModel errModel = new ErrorModel();
                errModel.Mensaje = ex.Message;
                errModel.InnerException = ex.InnerException.Message;
                return View("Error", errModel);
            }
        }

        public ActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProveedorViewModel provViewModel)
        {
            if (provViewModel.IdProveedor != 0)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        var prov = new Suppliers();
                        prov.SupplierID = provViewModel.IdProveedor;
                        prov.CompanyName = provViewModel.NombreProveedor;
                        prov.City = provViewModel.CiudadProveedor;
                        prov.Phone = provViewModel.TelefonoProveedor;
                        negProv.Update(prov);
                        return RedirectToAction("Index");
                    }
                    return View();
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
                    ModelState.Remove("IdProveedor");
                    if (ModelState.IsValid)
                    {
                        var prov = new Suppliers();
                        prov.CompanyName = provViewModel.NombreProveedor;
                        prov.City = provViewModel.CiudadProveedor;
                        prov.Phone = provViewModel.TelefonoProveedor;
                        negProv.Add(prov);
                        return RedirectToAction("Index");

                    }
                    return View();
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
                var prov = new Suppliers();
                prov.SupplierID = id;
                negProv.Delete(prov);

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

        public ActionResult Update(int id)
        {
            try
            {
                var prov = new Suppliers();
                prov = negProv.GetOne(id);

                var provViewModelEdit = new ProveedorViewModel();
                provViewModelEdit.IdProveedor = prov.SupplierID;
                provViewModelEdit.NombreProveedor = prov.CompanyName ;
                provViewModelEdit.CiudadProveedor = prov.City ;
                provViewModelEdit.TelefonoProveedor = prov.Phone ;

                return View("Insert", provViewModelEdit);
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