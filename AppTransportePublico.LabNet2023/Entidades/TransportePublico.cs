using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Entidades
{
    public abstract class TransportePublico
    {
        private int cantPasajeros;
        private string tipoTransporte;

        public int CantPasajeros { get; set; }
        public string TipoTransporte { get; }

        public TransportePublico(int _cantidadPasajeros, string _tipoTransporte)
        {
            this.CantPasajeros = _cantidadPasajeros;
            this.TipoTransporte = _tipoTransporte;
        }

        public abstract String Avanzar();
        public abstract String Detenerse();

    }
}
