using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public interface IProducts
    {
         IQueryable<Products> GetProductsWhitoutStockMethod();
         IQueryable<Products> GetProductsWhitoutStockSintax();
         IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Method();
         IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Sintax();
         Products GetFirstOrNull(int id);
         List<Products> GetOrderProductsList();
        List<Products> GetOrderProductsListByStock();
    }
}
