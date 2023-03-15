using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.LabNetPractica3;
using Moq;

namespace Datos.LabNetPractica3.Tests
{
    [TestClass()]
    public class DaoProveedorTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var data = new List<Suppliers>
            {
                new Suppliers { CompanyName = "Uno"},
                new Suppliers { CompanyName = "Dos"},
                new Suppliers { CompanyName = "Tres"}

            }.AsQueryable();

            var mockSet = new Mock<System.Data.Entity.DbSet<Suppliers>>();
            mockSet.As<IQueryable<Suppliers>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Suppliers>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Suppliers>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Suppliers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Suppliers).Returns(mockSet.Object);

            var serv = new DaoProveedor(mockContext.Object);
            var prov = serv.GetAll();

            Assert.AreEqual(3, prov.Count);
            Assert.AreEqual("Uno", prov[0].CompanyName);
            Assert.AreEqual("Dos", prov[1].CompanyName);
            Assert.AreEqual("Tres", prov[2].CompanyName);
        }
    }
}