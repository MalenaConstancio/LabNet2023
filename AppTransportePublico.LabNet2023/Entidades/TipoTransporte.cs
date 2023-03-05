using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Entidades
{
    public class TipoTransporte
    {
        private int id;
        private string nombreTipoTransporte;

        public int Id { get; set; }
        public string NombreTipoTransporte { get; set; }

        public TipoTransporte(int _id, string _nombreTipoTransporte)
        {
            this.id = _id;
            this.nombreTipoTransporte = _nombreTipoTransporte;
        }
    }
}
