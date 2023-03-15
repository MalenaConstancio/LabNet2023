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
        

        public DaoCategories() { 
        
        }

        public DaoCategories(NorthwindContext context)
        {
            _context = context;
        }

        public override bool Add(Categories entity)
        {
            Categories existe = _context.Categories.FirstOrDefault(x => x.CategoryName == entity.CategoryName);
            if (existe == null) {
                try
                {
                    _context.Categories.Add(entity);
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

     
    }
}
