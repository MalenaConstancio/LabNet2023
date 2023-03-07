using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.MisExcepciones
{
    class MiDivideByZeroException:Exception {

        public MiDivideByZeroException(String message) : base("Solo Chuck Norris divide por cero!") {  
        }

    }
}
