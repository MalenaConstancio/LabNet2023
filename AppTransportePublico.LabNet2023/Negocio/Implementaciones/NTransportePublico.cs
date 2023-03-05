
using AppTransportePublico.LabNet2023.Entidades;
using System;
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

            return lstTransportes;
        }

        public Boolean VerificarCantidad(List<TransportePublico> lstTransportes , TransportePublico oTransporte) {

            int cantidadTotalTaxis = 0;
            int cantidadTotalOmnibus = 0;
            foreach (var item in lstTransportes)
            {
                if (oTransporte.TipoTransporte.NombreTipoTransporte == "Taxi") {
                    cantidadTotalTaxis += 1;
                }
                else if (oTransporte.TipoTransporte.NombreTipoTransporte == "Omnibus") {
                    cantidadTotalOmnibus += 1;
                }
            }

            if (oTransporte.TipoTransporte.NombreTipoTransporte == "Taxi" && cantidadTotalTaxis < 5)
            {
                return true;
            }
            else if (oTransporte.TipoTransporte.NombreTipoTransporte == "Omnibus" && cantidadTotalOmnibus < 5)
            {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
