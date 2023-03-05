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
        private TipoTransporte tipoTransporte;

        public int CantPasajeros { get; set; }
        public TipoTransporte TipoTransporte { get; set; }

        public TransportePublico(int _cantidadPasajeros, TipoTransporte _oTipoTransporte)
        {
            this.CantPasajeros = _cantidadPasajeros;
            this.TipoTransporte = _oTipoTransporte;
        }

        public abstract String Avanzar();
        public abstract String Detenerse();

    }
}
