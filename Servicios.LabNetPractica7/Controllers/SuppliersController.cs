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
    public class SuppliersController : ApiController
    {
        IProveedor negProv = new NProveedor();

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<Suppliers> proveedores = negProv.GetAll();
                List<ProveedorModel> proveedoresModel = proveedores.Select(p => new ProveedorModel
                {
                    IdProveedor=p.SupplierID,
                    NombreProveedor=p.CompanyName,
                    CiudadProveedor=p.City,
                    TelefonoProveedor=p.Phone
                }).ToList();
                return Ok(proveedoresModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {

                Suppliers prov = negProv.GetOne(id);
                ProveedorModel provModel = new ProveedorModel();
                provModel.IdProveedor = prov.SupplierID;
                provModel.NombreProveedor = prov.CompanyName;
                provModel.CiudadProveedor = prov.City;
                provModel.TelefonoProveedor = prov.Phone;

                return Ok(provModel);
            }
            catch
            {

                return BadRequest("Error");
            }

        }

        [HttpPost]
        public IHttpActionResult Post(ProveedorModel provModel)
        {
            ModelState.Remove("IdProveedor");
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                try
                {

                    Suppliers prov = new Suppliers();
                    prov.CompanyName = provModel.NombreProveedor;
                    prov.City = provModel.CiudadProveedor;
                    prov.Phone= provModel.TelefonoProveedor;
                    negProv.Add(prov);

                    return Ok(prov);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPut]
        public IHttpActionResult Put(ProveedorModel provModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                try
                {

                    Suppliers prov = new Suppliers();
                    prov.SupplierID = provModel.IdProveedor;
                    prov.CompanyName = provModel.NombreProveedor;
                    prov.City = provModel.CiudadProveedor;
                    prov.Phone = provModel.TelefonoProveedor;
                    if (negProv.Update(prov))
                    {
                        return Ok(prov);
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

            Suppliers prov = new Suppliers();
            prov.SupplierID = id;

            if (negProv.Delete(prov))
            {
                return Ok();
            }
            else
            {
                return BadRequest("No se pueden eliminar Proveedores que tengan Productos asignados");
            }


        }
    
    }
}
