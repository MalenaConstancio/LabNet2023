using Entidades.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public interface IDaoBase<T>
    {
         bool Add(T entity);

         List<T> GetAll();

         bool Update(T entity);

         bool Delete(T entity);

         T GetOne(int id);
        int GetMaxId();
    }
}
