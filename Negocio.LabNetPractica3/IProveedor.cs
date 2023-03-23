using Entidades.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public interface IProveedor
    {
        bool Add(Suppliers entity);

        List<Suppliers> GetAll();

        bool Update(Suppliers entity);

        bool Delete(Suppliers entity);

        Suppliers GetOne(int id);
    }
}
