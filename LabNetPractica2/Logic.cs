using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public static class Logic
    {

        public static int SolicitarUnNumero()
        {

            Console.WriteLine("Ingrese un número entero: ");
            string numIngresado = Console.ReadLine();

            int numero = 0;
            while (!int.TryParse(numIngresado, out numero))
            {

                Console.WriteLine("Ingrese un número válido: ");
                numIngresado = Console.ReadLine();
            }
            return numero;
        }

        public static void DividirPorCero(int divisor)
        {
            try
            {
                decimal resultado = divisor / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(divisor + "/0");
                Console.WriteLine("Fin");
                Console.WriteLine(" ");
            }

        }


    }
}
