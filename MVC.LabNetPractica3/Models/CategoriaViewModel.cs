using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.LabNetPractica3.Models
{
    public class CategoriaViewModel
    {
        
        public int IdCategoria { get; set; }

        [Required (ErrorMessage = "Debe ingresar una Categoria.")]
        [StringLength(15, ErrorMessage = "No puede excederse de los 15 caracteres.")]
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
    }
}