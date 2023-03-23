using Entidades.LabNetPractica3;
using Datos.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public class NProveedor : IProveedor
    {
        DaoProveedor daoProv = new DaoProveedor();
        public bool Add(Suppliers entity)
        {
            if (daoProv.Add(entity)) {
                return true;
            }
            return false;
        }

        public bool Delete(Suppliers entity)
        {
            if (daoProv.Delete(entity))
            {
                return true;
            }
            return false;
        }

        public List<Suppliers> GetAll()
        {
            List<Suppliers> lstProveedores = daoProv.GetAll();
            return lstProveedores;
        }

        public Suppliers GetOne(int id)
        {
           Suppliers prov= daoProv.GetOne(id);
            return prov;
        }

        public bool Update(Suppliers entity)
        {
            if (daoProv.Update(entity))
            {
                return true;
            }
            return false;
        }
    }
}
