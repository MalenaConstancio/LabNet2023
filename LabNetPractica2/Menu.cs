using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Menu
    {
        public int SeleccionarEjercicio() {

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

    }
}
