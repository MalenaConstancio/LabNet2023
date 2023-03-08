using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.MisExcepciones
{
   public class MiDivideByZeroException : Exception
    {
        public MiDivideByZeroException(string message) : base("Solo Chuck Norris divide por cero!") { }
    }
}
