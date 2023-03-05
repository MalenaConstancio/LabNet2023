using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Entidades
{
    public class Omnibus : TransportePublico
    {
        public const int cantMaxPasajeros = 100;

        public Omnibus(int _cantidadPasajeros, TipoTransporte _oTipoTransporte) : base(_cantidadPasajeros, _oTipoTransporte)
        {

        }

        public override string Avanzar()
        {
            return "Omnibus con "+ CantPasajeros +" pasajeros avanzando.";
        }

        public override string Detenerse()
        {
            return "Omnibus con " + CantPasajeros + " pasajeros deteniendose.";
        }


    }
}
