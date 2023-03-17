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

        public DaoCustomer()
        {
        }

        NorthwindContext db = new NorthwindContext();

        public IQueryable<Customers> GetCustomerSintax(string idCustomer) {

            var queryCustomer = from cust in db.Customers
                                where cust.CustomerID == idCustomer
                                select cust;

            return queryCustomer;
        }

        public List<Customers> GetCustomerMethod(string idCustomer)
        {

            var queryCustomer = db.Customers.Select(e => e).Where(e => e.CustomerID == idCustomer).ToList();

            return queryCustomer;
        }

        public List<Customers> GetAllCustomers()
        {
            var queryCustomer = db.Customers.Select(e => e).ToList();

            return queryCustomer;
        }

        public IQueryable<Customers> GetCustomersRegionWASintax()
        {
            var queryCustomer = from cust in db.Customers
                                where cust.Region == "WA"
                                select cust;

            return queryCustomer;

        }

        public IQueryable<Customers> GetCustomersRegionWAMethod()
        {
            var queryCustomer = db.Customers.Select(e => e).Where(e => e.Region == "WA");

            return queryCustomer;
        }

    }
}
