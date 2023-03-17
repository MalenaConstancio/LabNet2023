using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public interface ICustomer
    {
         List<Customers> GetAllCustomers();
        IQueryable<Customers> GetCustomerSintax(string idCustomer);
    }
}
