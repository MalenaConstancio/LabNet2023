using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.LabNetPractica3;

namespace Negocio.LabNetPractica3
{
    public interface INCategories
    {
        bool Add(Categories entity);

        List<Categories> GetAll();

        bool Update(Categories entity);

        bool Delete(Categories entity);
        Categories GetOne(Categories entity);



    }
}
