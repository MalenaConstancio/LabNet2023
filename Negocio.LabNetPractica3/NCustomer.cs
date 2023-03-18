using Datos.LabNetPractica3;
using Entidades.LabNetPractica3;
using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public class NCustomer : ICustomer
    {
        DaoCustomer daoCus = new DaoCustomer();
        public List<Customers> GetAllCustomers()
        {
            List<Customers> lstCustomers = new List<Customers> (daoCus.GetAllCustomers());
            return lstCustomers;
        }

        public IQueryable<Customers> GetCustomerSintax(string idCustomer)
        {
            var lstCustomers = daoCus.GetCustomerSintax(idCustomer);
            return lstCustomers;
        }

        public List<Customers> GetCustomersNamesLowerMethod()
        {
            var lstCustomersNamesLower = daoCus.GetCustomersNamesLowerMethod();
            return lstCustomersNamesLower;
        }

        public List<Customers> GetCustomersNamesMayusMethod()
        {
            var lstCustomersNamesMayus = daoCus.GetCustomersNamesMayusMethod();
            return lstCustomersNamesMayus;
        }

        public List<Customers> GetCustomersNamesSintax()
        {
            var lstCustomersNames = daoCus.GetCustomersNamesSintax();
            return lstCustomersNames;
        }

        public IQueryable<Customers> GetCustomersRegionWAMethod()
        {
            var lstCustomers = daoCus.GetCustomersRegionWAMethod();
            return lstCustomers;
        }

        public List<CustomersDTO> GetCustomersWARegionAndOrdersAfter1997()
        {
            var lstCustomers=daoCus.GetCustomersWARegionAndOrdersAfter1997();
            return lstCustomers;
        }

        public List<Customers> GetTop3CustomersWARegion() {
            var lstCustomers = daoCus.GetTop3CustomersWARegion();
            return lstCustomers;
        }

        public List<OrdersDTO> GetTotalOrdersByCustomer()
        {
            var lst = daoCus.GetTotalOrdersByCustomer();
            return lst;
        }
    }
}
