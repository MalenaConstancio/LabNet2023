using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public static class Menu
    {
        public static int SeleccionarEjercicio() {

            Console.WriteLine("Elija una opción : ");
            Console.WriteLine("Escriba 1 para Ejercicio 1");
            Console.WriteLine("Escriba 2 para Ejercicio 2");
            Console.WriteLine("Escriba 3 para Ejercicio 3");
            Console.WriteLine("Escriba 4 para Ejercicio 4");
            Console.WriteLine("Escriba 5 para SALIR");
            string opcionString =Console.ReadLine();

            int opcion = 0;
            while (!int.TryParse(opcionString, out opcion) || (opcionString != "1" && opcionString != "2" && opcionString != "3" && opcionString != "4" && opcionString != "5"))
            {
                Console.WriteLine("Ingrese un número válido: ");
                opcionString = Console.ReadLine();
            }
                Console.WriteLine("");
                Console.WriteLine("Seleccionaste " + opcion);
                Console.WriteLine("");

            return opcion;
        }

        //Ejercicio 1:
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

        //Ejercicio 2:
        public static int[] SolicitarDosNumeros() {

            Console.WriteLine("Ingrese el dividendo: ");
            string numUno = Console.ReadLine();
            Console.WriteLine("Ingrese el divisor: ");
            string numDos = Console.ReadLine();

            int[] dosNumeros =null;

            try {
                dosNumeros = new int[2];
                dosNumeros[0] = Convert.ToInt32(numUno);
                dosNumeros[1] = Convert.ToInt32(numDos);
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            return dosNumeros;
        }

    }
}
