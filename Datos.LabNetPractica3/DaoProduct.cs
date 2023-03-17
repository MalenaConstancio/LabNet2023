
using Datos.LabNetPractica4;
using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LabNetPractica3
{
    public class DaoProduct : DaoBase<Products>
    {

        public DaoProduct(NorthwindContext context)
        {
            _context = context;
        }

        public DaoProduct()
        {
        }

        NorthwindContext db = new NorthwindContext();

        public IQueryable<Products> GetProductsWhitoutStockMethod() {

            IQueryable<Products> queryProducts = db.Products.Select(p => p).Where(p => p.UnitsInStock == 0);
            return queryProducts;
        }

        public IQueryable<Products> GetProductsWhitoutStockSintax()
        {

            IQueryable<Products> queryProducts = from prod in db.Products
                                                 where prod.UnitsInStock == 0
                                                 select prod; 
            return queryProducts;
        }

        public List<Products> GetAll()
        {
            List<Products> lstProducts = db.Products.Select(p => p).ToList();
            return lstProducts;
        }
    }
}
