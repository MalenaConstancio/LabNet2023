using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public interface IDaoBase<T>
    {
         void Add(T entity);

         List<T> GetAll();

         void Update(T entity);

         void Delete(T entity);
    }
}
