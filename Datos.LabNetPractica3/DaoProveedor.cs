using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.LabNetPractica4;

namespace Datos.LabNetPractica4
{
    public class DaoProveedor : DaoBase<Suppliers>
    {
        

        public DaoProveedor()
        {
        }

        public DaoProveedor(NorthwindContext context)
        {
            _context = context;
        }

    }
}
