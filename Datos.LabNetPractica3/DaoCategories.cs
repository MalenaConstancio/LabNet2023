using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.LabNetPractica3;

namespace Datos.LabNetPractica3
{
    public class DaoCategories : DaoBase<Categories>
    {
        

        public DaoCategories() { 
        
        }

        public DaoCategories(NorthwindContext context)
        {
            _context = context;
        }


     
    }
}
