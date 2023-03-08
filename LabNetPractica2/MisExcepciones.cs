using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public static class MisExcepciones
    {
        public static void DispararMiExcepcion()
        {
            Console.WriteLine("▌─────────────────────────▐█─────▐");
            Console.WriteLine("▌────▄──────────────────▄█▓█▌────▐");
            Console.WriteLine("▌───▐██▄───────────────▄▓░░▓▓────▐");
            Console.WriteLine("▌───▐█░██▓────────────▓▓░░░▓▌────▐");
            Console.WriteLine("▌───▐█▌░▓██──────────█▓░░░░▓─────▐");
            Console.WriteLine("▌────▓█▌░░▓█▄███████▄███▓░▓█─────▐");
            Console.WriteLine("▌────▓██▌░▓██░░░░░░░░░░▓█░▓▌─────▐");
            Console.WriteLine("▌─────▓█████░░░░░░░░░░░░▓██──────▐");
            Console.WriteLine("▌─────▓██▓░░░░░░░░░░░░░░░▓█──────▐");
            Console.WriteLine("▌─────▐█▓░░░░░░█▓░░▓█░░░░▓█▌─────▐");
            Console.WriteLine("▌─────▓█▌░▓█▓▓██▓░█▓▓▓▓▓░▓█▌─────▐");
            Console.WriteLine("▌─────▓▓░▓██████▓░▓███▓▓▌░█▓─────▐");
            Console.WriteLine("▌────▐▓▓░█▄▐▓▌█▓░░▓█▐▓▌▄▓░██─────▐");
            Console.WriteLine("▌────▓█▓░▓█▄▄▄█▓░░▓█▄▄▄█▓░██▌────▐");
            Console.WriteLine("▌────▓█▌░▓█████▓░░░▓███▓▀░▓█▓────▐");
            Console.WriteLine("▌───▐▓█░░░▀▓██▀░░░░░─▀▓▀░░▓█▓────▐");
            Console.WriteLine("▌───▓██░░░░░░░░▀▄▄▄▄▀░░░░░░▓▓────▐");
            Console.WriteLine("▌───▓█▌░░░░░░░░░░▐▌░░░░░░░░▓▓▌───▐");
            Console.WriteLine("▌───▓█░░░░░░░░░▄▀▀▀▀▄░░░░░░░█▓───▐");
            Console.WriteLine("▌──▐█▌░░░░░░░░▀░░░░░░▀░░░░░░█▓▌──▐");
            Console.WriteLine("▌──▓█░░░░░░░░░░░░░░░░░░░░░░░██▓──▐");
            Console.WriteLine("▌──▓█░░░░░░░░░░░░░░░░░░░░░░░▓█▓──▐");
            Console.WriteLine("▌──██░░░░░░░░░░░░░░░░░░░░░░░░█▓──▐");
            Console.WriteLine("▌──█▌░░░░░░░░░░░░░░░░░░░░░░░░▐▓▌─▐");
            Console.WriteLine("▌─▐▓░░░░░░░░░░░░░░░░░░░░░░░░░░█▓─▐");
            Console.WriteLine("▌─█▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓─▐");
            Console.WriteLine("▌─█▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▌▐");
            Console.WriteLine("▌▐█▓░░░░░░░░░░░░░░░░░░░░░░░░░░░██▐");
            Console.WriteLine("▌█▓▌░░░░░░░░░░░░░░░░░░░░░░░░░░░▓█▐");
            Console.WriteLine("██████████████████████████████████");
            Console.WriteLine("█░▀░░░░▀█▀░░░░░░▀█░░░░░░▀█▀░░░░░▀█");
            Console.WriteLine("█░░▐█▌░░█░░░██░░░█░░██░░░█░░░██░░█");
            Console.WriteLine("█░░▐█▌░░█░░░██░░░█░░██░░░█░░░██░░█");
            Console.WriteLine("█░░▐█▌░░█░░░██░░░█░░░░░░▄█░░▄▄▄▄▄█");
            Console.WriteLine("█░░▐█▌░░█░░░██░░░█░░░░████░░░░░░░█");
            Console.WriteLine("█░░░█░░░█▄░░░░░░▄█░░░░████▄░░░░░▄█");
            Console.WriteLine("██████████████████████████████████");
            throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
        }


    }
}
