using Datos.LabNetPractica3;
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
    }
}
