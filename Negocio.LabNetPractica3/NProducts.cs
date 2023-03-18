using Datos.LabNetPractica3;
using Entidades.LabNetPractica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LabNetPractica3
{
    public class NProducts : IProducts, IBase<Products>
    {
        DaoProduct daoProd = new DaoProduct();
        public List<Products> GetAll()
        {
            List<Products> lstProd= daoProd.GetAll();
            return lstProd;
        }

        public List<Categories> GetCategories()
        {
            List<Categories> lstCategories = daoProd.GetCategories();
            return lstCategories;
        }

        public Products GetFirst(List<Products> lst)
        {
            Products p = daoProd.GetFirst(lst);
            return p;
        }

        public Products GetFirstOrNull(int id)
        {
            Products prod =daoProd.GetFirstOrNull(id);
            return prod;
        }

        public List<Products> GetOrderProductsList()
        {
            List<Products> lstProducts = daoProd.GetOrderProductsList();
            return lstProducts;
        }

        public List<Products> GetOrderProductsListByStock()
        {
            List<Products> lstProducts = daoProd.GetOrderProductsListByStock();
            return lstProducts;
        }

        public IQueryable<Products> GetProductsWhitoutStockMethod()
        {
            IQueryable<Products> entity= daoProd.GetProductsWhitoutStockMethod();
            return entity;

        }

        public IQueryable<Products> GetProductsWhitoutStockSintax()
        {
            IQueryable<Products> entity = daoProd.GetProductsWhitoutStockSintax();
            return entity;
        }

        public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Method()
        {
            IQueryable<Products> entity = daoProd.GetProductsWhitStockUnitPriceGreaterThan3Method();
            return entity;
        }

        public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Sintax()
        {

            IQueryable<Products> entity = daoProd.GetProductsWhitStockUnitPriceGreaterThan3Sintax();
            return entity;
        }
    }
}
