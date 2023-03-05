using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Entidades
{
    public class Taxi : TransportePublico
    {
        public const int cantMaxPasajeros=4;

        public Taxi(int _cantidadPasajeros, TipoTransporte _oTipoTransporte) : base ( _cantidadPasajeros,_oTipoTransporte)
        {
            
        }
        
        public override string Avanzar()
        {
            return "Taxi con" + CantPasajeros + "avanzando.";
        }

        public override string Detenerse()
        {
            return "Taxi con" + CantPasajeros + "deteniendose.";
        }
    }
}
