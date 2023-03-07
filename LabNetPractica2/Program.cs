using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabNetPractica2.Logic;


namespace LabNetPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int opcion = menu.SeleccionarEjercicio();
  
            while (opcion != 5) {

                switch (opcion)
                {
                    case 1:
                        int numero = SolicitarUnNumero();
                        DividirPorCero(numero);
                        Console.ReadKey();
                        break;
                    case 2:

                    default:
                        break;
                }

                opcion = menu.SeleccionarEjercicio();
            }
            if (opcion == 5) {
                Console.WriteLine("Saliendo...");
                Console.ReadKey();
            }
        }
    }
}
