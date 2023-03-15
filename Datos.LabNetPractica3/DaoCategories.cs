using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.LabNetPractica3;

namespace Datos.LabNetPractica3
{
    public class DaoCategories : DaoBase<Categories>
    {


        public override bool Add(Categories entity)
        {
            if (Exists(entity)) { 
                try
                {   
                    _context.Categories.Add(entity);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception) {
                    throw;
                }
            }
            return false;
        }

        public override bool Update(Categories entity)
        {
            Categories categorieToUpdate = _context.Categories.Find(entity.CategoryID);
            if (categorieToUpdate != null)
            {
                try
                {
                    categorieToUpdate.CategoryName = entity.CategoryName;
                    categorieToUpdate.Description = entity.Description;
                    _context.Entry(categorieToUpdate).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }

        public override bool Delete(Categories entity)
        {
            Categories categorieToDelete = _context.Categories.Find(entity.CategoryID);
            if (categorieToDelete != null)
            {
                try
                {
                    _context.Categories.Remove(categorieToDelete);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                  throw;
                }
            }
            return false;
        }

        public override List<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public override bool Exists(Categories entity)
        {
            DaoCategories daoCat = new DaoCategories();
            try
            {
                var existe = from categorie in daoCat.GetAll()
                             where categorie.CategoryName == entity.CategoryName
                             select categorie;

                
                if (existe == null)
                {
                    return false;
                }
                
                return true;

            }
            catch (Exception) {
                throw;
            }
          
        }
    }
}
