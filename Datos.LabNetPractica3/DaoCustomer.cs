using Datos.LabNetPractica4;
using Entidades.LabNetPractica3;
using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public class DaoCustomer : DaoBase<Customers>
    {

        public DaoCustomer(NorthwindContext context)
        {
            _context = context;
        }

        public DaoCustomer()
        {
        }

        NorthwindContext db = new NorthwindContext();

        public IQueryable<Customers> GetCustomerSintax(string idCustomer)
        {

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

        public List<Customers> GetCustomersNamesSintax()
        {

            var queryCustomer = from cust in db.Customers
                                select cust.CompanyName;

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

        public List<CustomersDTO> GetCustomersWARegionAndOrdersAfter1997()
        {

            DateTime fecha = new DateTime(1997, 1, 1);
            var queryCustomer = db.Customers.Join(db.Orders,
                                c => c.CustomerID,
                                o => o.CustomerID,
                                (c, o) => new
                                {
                                    c.CompanyName,
                                    c.Region,
                                    o.OrderID,
                                    o.OrderDate
                                })
                                    .Where(e => e.Region == "WA")
                                    .Where(e => e.OrderDate > fecha);

            List<CustomersDTO> lstCustomersNames = new List<CustomersDTO>();

            foreach (var item in queryCustomer)
            {
                CustomersDTO c = new CustomersDTO();
                c.CompanyName = item.CompanyName;
                c.Region = item.Region;
                c.OrderID = item.OrderID;
                c.OrderDate = Convert.ToDateTime(item.OrderDate);
                lstCustomersNames.Add(c);
            }

            return lstCustomersNames;
        }

        public List<Customers> GetTop3CustomersWARegion()
        {

            var queryCustomer = db.Customers.Select(e => e).Where(e => e.Region == "WA").Take(3).ToList();
            return queryCustomer;
        }

        public List<OrdersDTO> GetTotalOrdersByCustomer()
        {

            var queryCustomer = db.Customers.Join(db.Orders,
                                c => c.CustomerID,
                                o => o.CustomerID,
                                (c, o) => new
                                {
                                    c.CompanyName,
                                    o.CustomerID,
                                }).GroupBy(m => new { m.CustomerID, m.CompanyName });


            List<OrdersDTO> lst = new List<OrdersDTO>();
            foreach (var group in queryCustomer)
            {

                OrdersDTO oDto = new OrdersDTO();
                oDto.CustomerID = group.Key.CustomerID;
                oDto.CompanyName = group.Key.CompanyName;
                oDto.TotalOrders = group.Count();
                lst.Add(oDto);
            }
            return lst;
        }

    }
}
