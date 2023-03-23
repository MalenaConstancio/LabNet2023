using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.LabNetPractica3;
using Datos.LabNetPractica3;

namespace Negocio.LabNetPractica3
{
    public class NCategories : INCategories
    {
        DaoCategories daoCat = new DaoCategories();

        public bool Add(Categories entity)
        {
            if (daoCat.Add(entity))
            {
                return true;
            }
            return false;
        }

        public bool Delete(Categories entity)
        {
            if (daoCat.Delete(entity))
            {
                return true;
            }
            return false;
        }

        public List<Categories> GetAll()
        {
            List<Categories> lstCategorias = daoCat.GetAll();
            return lstCategorias;
        }

        public int GetMaxId( )
        {
            int maxId = daoCat.GetMaxId();
            return maxId;
        }

        public Categories GetOne(int id)
        {
            Categories cat = daoCat.GetOne(id);
            return cat;
        }

        public bool Update(Categories entity)
        {
            if (daoCat.Update(entity)) {
                return true;
            }
            return false;
           
        }
    }
}
