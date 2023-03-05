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
        private string tipoTransporte = "Taxi";

        public string TipoTransporte
        {
            get { return tipoTransporte; }
        }

        public Taxi(int _cantidadPasajeros, string _tipoTransporte) : base ( _cantidadPasajeros,_tipoTransporte)
        {
            
        }
        
        public override string Avanzar()
        {
            return "Taxi con " + CantPasajeros + " pasajeros avanzando.";
        }

        public override string Detenerse()
        {
            return "Taxi con " + CantPasajeros + " pasajeros deteniendose.";
        }
    }
}
