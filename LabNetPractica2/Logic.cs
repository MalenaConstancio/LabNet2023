
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public static class Logic
    {
        //Ejercicio 1:
        public static decimal DividirPorCero(int divisor)
        {
            decimal resultado = divisor / 0;
            return resultado;
        }
        //Ejercicio 2:
        public static decimal Dividir(int dividendo, int divisor) 
        {
            decimal resultado = dividendo / divisor;
            return resultado;
        }
        //Ejercicio 3:
        public static void MostrarExcepcion() {
            throw new StackOverflowException();
        }


    }
}
