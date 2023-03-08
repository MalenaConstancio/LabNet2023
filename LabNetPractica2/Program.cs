
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabNetPractica2.Logic;
using static LabNetPractica2.Menu;
using static LabNetPractica2.MiDivideByZero;




namespace LabNetPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = SeleccionarEjercicio();
  
            while (opcion != 5) {

                switch (opcion)
                {
                    //Ejercicio 1:
                    case 1:
                        int numero = SolicitarUnNumero();
                        try {
                            decimal resultado;
                            resultado = DividirPorCero(numero);
                        }
                        catch (DivideByZeroException ex) {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(numero + "/0");
                        }
                        finally {
                            Console.WriteLine("Fin");
                            Console.WriteLine("------------------------\n");
                        }
                        Console.ReadKey();
                        break;
                    //Ejercicio 2:
                    case 2:
                        int[] dosNumeros = SolicitarDosNumeros();
                        if (dosNumeros != null) {
                            int dividendo = dosNumeros[0];
                            int divisor = dosNumeros[1];
                            decimal division=0;
                            try
                            {
                                division = Dividir(dividendo, divisor);
                                Console.WriteLine("El resultado es " + division);
                            }
                            catch (DivideByZeroException ex)
                            {
                                try { DispararMiExcepcion();}
                                catch (Exception e) { Console.WriteLine(e.Message);}
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fin");
                                Console.WriteLine("------------------------\n");
                            }
                        }
                        break;
                    //Ejercicio 3:
                    case 3:
                        
                        try {
                            MostrarExcepcion();
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.GetType());
                        }
                        finally {
                            Console.WriteLine("Fin");
                            Console.WriteLine("------------------------\n");
                        }
                        break;
                    case 4:
                        try {
                            MostrarMiExcepcion("\nSoy el mensaje agregado por la pantalla");
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.GetType());
                        }
                        finally
                        {
                            Console.WriteLine("Fin");
                            Console.WriteLine("------------------------\n");
                        }
                        break;
                    default:
                        break;
                }

                opcion = SeleccionarEjercicio();
            }
            if (opcion == 5) {
                Console.WriteLine("Saliendo...");
                Console.ReadKey();
            }
        }
    }
}
