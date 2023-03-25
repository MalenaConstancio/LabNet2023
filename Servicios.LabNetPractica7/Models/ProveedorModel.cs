using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Servicios.LabNetPractica7.Models
{
    public class ProveedorModel
    {
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Proveedor.")]
        [StringLength(30, ErrorMessage = "No puede excederse de los 30 caracteres.")]
        public string NombreProveedor { get; set; }

        [StringLength(15, ErrorMessage = "No puede excederse de los 15 caracteres.")]
        public string CiudadProveedor { get; set; }


        [StringLength(24, ErrorMessage = "No puede excederse de los 24 caracteres.")]
        public string TelefonoProveedor { get; set; }
    }
}