using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.MisExcepciones
{
    public class MiStackOverflowException : Exception
    {
        public MiStackOverflowException(string message):base("Soy el mensaje de la clase base"+message)
        {

        }
    }
}
