
using AppTransportePublico.LabNet2023.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Negocio.Implementaciones
{
    public class NTransportePublico : Interfaces.ITransportePublico
    {
        public List<TransportePublico> AgregarTransporte(List<TransportePublico> lstTransportes, TransportePublico oTransporte) {

            if (VerificarCantidad(lstTransportes, oTransporte))
            {
                lstTransportes.Add(oTransporte);
            }
            else
            {
                return null;
            }

            return lstTransportes;
        }

        public ArrayList ContarTransportes(List<TransportePublico> lstTransportes) {

            int cantidadTaxis = 0;
            int cantidadOmnibus = 0;
           
            foreach (var item in lstTransportes)
            {
                if (item.TipoTransporte == "Taxi")
                {
                    cantidadTaxis += 1;
                }
                else if (item.TipoTransporte == "Omnibus")
                {
                    cantidadOmnibus += 1;
                }
            }

            ArrayList arrCantidades = new ArrayList();
            arrCantidades.Add(cantidadTaxis);
            arrCantidades.Add(cantidadOmnibus);

            return arrCantidades;
        }

        public Boolean VerificarCantidad(List<TransportePublico> _lstTransportes, TransportePublico _oTransporte) {

            ArrayList arrCantidades = ContarTransportes(_lstTransportes);
            int cantidadTotalTaxis = (int)arrCantidades[0];
            int cantidadTotalOmnibus = (int)arrCantidades[1];

            if (_oTransporte.TipoTransporte == "Taxi" && cantidadTotalTaxis < 5)
            {
                return true;
            }
            else if (_oTransporte.TipoTransporte == "Omnibus" && cantidadTotalOmnibus < 5) 
            { 
                return true;
            }
            else {
                return false;
            }
        }

    }
}
