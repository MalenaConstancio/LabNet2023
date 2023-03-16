using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public abstract class DaoBase<T>:IDaoBase<T> 
    {
        protected NorthwindContext _context;
        public DaoBase()
        {
            _context = new NorthwindContext();
        }

       

        
   
    }
}
