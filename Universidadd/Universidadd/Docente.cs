using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidadd
{
    class Docente : Persona
    {
        public override String getDatos()
        {
            return "Docente: " + nombres + " " + apellidos;
        }
    }
}
