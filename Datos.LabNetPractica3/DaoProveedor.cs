using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.LabNetPractica3;

namespace Datos.LabNetPractica3
{
    public class DaoProveedor : DaoBase<Suppliers>
    {
       

        public DaoProveedor()
        {
        }

        public DaoProveedor(NorthwindContext context)
        {
            _context = context;
        }

        public override bool Add(Suppliers entity)
        {
            Suppliers existe = _context.Suppliers.FirstOrDefault(x => x.CompanyName == entity.CompanyName);
            if (existe == null)
            {
                try
                {
                    _context.Suppliers.Add(entity);
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

        public override bool Delete(Suppliers entity)
        {
            Suppliers supplierToDelete = _context.Suppliers.Find(entity.SupplierID);
            if (supplierToDelete != null)
            {
                try
                {
                    _context.Suppliers.Remove(supplierToDelete);
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

        public override List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public override bool Update(Suppliers entity)
        {
            Suppliers supplierToUpdate = _context.Suppliers.Find(entity.SupplierID);
            if (supplierToUpdate != null)
            {
                try
                {
                    supplierToUpdate.CompanyName= entity.CompanyName;
                    supplierToUpdate.ContactName = entity.ContactName;
                    supplierToUpdate.Phone = entity.Phone;
                    _context.Entry(supplierToUpdate).State = System.Data.Entity.EntityState.Modified;
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
    }
}
