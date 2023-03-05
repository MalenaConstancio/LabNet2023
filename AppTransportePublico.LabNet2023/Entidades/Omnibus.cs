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
        private string tipoTransporte= "Omnibus";

        public string TipoTransporte
        {
            get { return tipoTransporte; }
        }


        public Omnibus(int _cantidadPasajeros, string _tipoTransporte) : base(_cantidadPasajeros,_tipoTransporte)
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
