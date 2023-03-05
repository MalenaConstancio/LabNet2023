using AppTransportePublico.LabNet2023.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePublico.LabNet2023.Negocio.Interfaces
{
    interface ITransportePublico
    {
        List<TransportePublico> AgregarTransporte(List<TransportePublico> lstTransportes,TransportePublico oTransporte);
        ArrayList ContarTransportes(List<TransportePublico> lstTransportes);
        Boolean VerificarCantidad(List<TransportePublico> lstTransportes, TransportePublico oTransporte);
    }
}
