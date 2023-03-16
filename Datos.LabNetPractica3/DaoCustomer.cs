using Datos.LabNetPractica4;
using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public class DaoCustomer:DaoBase<Customers>
    {

        public DaoCustomer(NorthwindContext context)
        {
            _context = context;
        }

        NorthwindContext db = new NorthwindContext();

        public IQueryable<Customers> GetCustomerSintax(string idCustomer) {

            var queryCustomer = from cust in db.Customers
                                where cust.CustomerID == idCustomer
                                select cust;

            return queryCustomer;
        }

        public List<Customers> GetCustomerMethod()
        {

            var queryCustomer = db.Customers.Select(e => e).ToList();

            return queryCustomer;
        }



    }
}
