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
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCeroTest()
        {
            //arrange
            int divisor = 5;
            //act
            Logic.DividirPorCero(divisor);
        }

        [TestMethod()]
        public void DividirTest()
        {
            //arrange
            int dividendo=4;
            int divisor=2;
            decimal resultadoEsperado=2;
            //act
           decimal resultadoActual=Logic.Dividir(4,2);
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }


        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirExceptionTest()
        {
            //arrange
            int dividendo = 4;
            int divisor = 0;
            //act
            Logic.Dividir(4, 0);
        }
    }
}