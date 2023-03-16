using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.LabNetPractica4;

namespace Datos.LabNetPractica4
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
