using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabNetPractica2.Tests
{
    [TestClass()]
    public class MenuTests
    {
        [TestMethod()]
        public void SeleccionarEjercicioTest()
        {
            //arrange
            int opcionEsperada = 1;
            //act
            int opcionActual = Menu.SeleccionarEjercicio();
            //assert
            Assert.AreEqual(opcionEsperada, opcionActual);
        }

        //[TestMethod()]
        //public void SolicitarUnNumeroTest()
        //{
        //    //arrange
        //    //act
        //    //assert
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void SolicitarDosNumerosTest()
        //{
        //    //arrange
        //    //act
        //    //assert
        //    Assert.Fail();
        //}
    }
}