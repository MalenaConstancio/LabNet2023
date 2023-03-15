using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using Entidades.LabNetPractica3;
using System.Collections;

namespace Datos.LabNetPractica3.Tests
{
    [TestClass()]
    public class DaoCategoriesTests
    {
        //No pude corregir la excepcion que me arroja
        //Pase el depurador de pruebas y me arroja la ex cuando ejecuta la validacion para verificar 
        //si ese registro ya existe  Línea 26  DaoCategories.cs
        [TestMethod()]
        public void AddTest()
        {
            Categories cat = new Categories();
            cat.CategoryID = 145;
            cat.CategoryName = "TestName";
            cat.Description = "TestDescription";

            var mockSet = new Mock<DbSet<Categories>>();
         
            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            DaoCategories daoCat = new DaoCategories(mockContext.Object);
          
            daoCat.Add(cat);

            mockSet.Verify(m => m.Add(It.IsAny<Categories>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod()]
        public void GetAllTest()
        {
            var data = new List<Categories>
            {
                new Categories { CategoryName = "Uno" },
                new Categories { CategoryName = "Dos" },
                new Categories { CategoryName = "Tres" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Categories>>();
            mockSet.As<IQueryable<Categories>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Categories>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Categories>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Categories>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Categories).Returns(mockSet.Object);

            var service = new DaoCategories(mockContext.Object);
            var blogs = service.GetAll();

            Assert.AreEqual(3, blogs.Count);
            Assert.AreEqual("Uno", blogs[0].CategoryName);
            Assert.AreEqual("Dos", blogs[1].CategoryName);
            Assert.AreEqual("Tres", blogs[2].CategoryName);
        }



    }
}