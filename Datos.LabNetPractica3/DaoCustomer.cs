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

        public List<Customers> GetCustomersNamesSintax() {

            var queryCustomer = from cust in db.Customers  
                                select  cust.CompanyName;

            List<Customers> lstCustomersNames = new List<Customers>();

            foreach (var item in queryCustomer)
            {
                Customers c = new Customers();
                c.CompanyName = item;
                lstCustomersNames.Add(c);
            }

            return lstCustomersNames;
        }
        public List<Customers> GetCustomersNamesMayusMethod()
        {
            var queryCustomersMayuscula = db.Customers.Select(e => e.CompanyName);

            List<Customers> lstCustomersNames = new List<Customers>();

            foreach (var item in queryCustomersMayuscula)
            {
                Customers c = new Customers();
                c.CompanyName = item.ToUpper();
                lstCustomersNames.Add(c);
            }


            return lstCustomersNames;

        }

        public List<Customers> GetCustomersNamesLowerMethod()
        {
            var queryCustomersMayuscula = db.Customers.Select(e => e.CompanyName);

            List<Customers> lstCustomersNames = new List<Customers>();

            foreach (var item in queryCustomersMayuscula)
            {
                Customers c = new Customers();
                c.CompanyName = item.ToLower();
                lstCustomersNames.Add(c);
            }


            return lstCustomersNames;
        }
    }
}
