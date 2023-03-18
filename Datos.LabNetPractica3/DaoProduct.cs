
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

        public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Sintax() {
           
            IQueryable<Products> queryProducts = from prod in db.Products
                                                 where prod.UnitsInStock != 0  
                                                 && prod.UnitPrice>3
                                                 select prod;
            return queryProducts;
        }
        public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Method()
        {

            IQueryable<Products> queryProducts = db.Products.Select(p => p).Where(p => p.UnitsInStock != 0).Where(p => p.UnitPrice>3);
            return queryProducts;
        }

        public Products GetFirstOrNull(int id)
        {
            Products prod = db.Products.Select(p => p).Where(p => p.ProductID == id).FirstOrDefault();
            return prod;
        }

        public Products GetFirst(List<Products> lst)
        {
            Products prod = lst.First();
            return prod;
        }

        public List<Products> GetOrderProductsList() {

            List<Products> queryProducts = db.Products.Select(p => p).OrderBy(p => p.ProductName).ToList();
            return queryProducts;
        }

        public List<Products> GetOrderProductsListByStock()
        {

            List<Products> queryProducts = (from product in db.Products
                                           orderby product.UnitsInStock descending
                                           select product).ToList();
            return queryProducts;
        }

        public List<Categories> GetCategories() {

            var queryProducts = (from p in db.Products
                                join c in db.Categories on p.CategoryID equals c.CategoryID
                                select  c.CategoryName).Distinct();

            List<Categories> lstCategorias = new List<Categories>();
            foreach (var item in queryProducts)
            {
                Categories c = new Categories();
                c.CategoryName = item.ToString(); ;
                lstCategorias.Add(c);
            }

            return lstCategorias;
        }

    }
}
