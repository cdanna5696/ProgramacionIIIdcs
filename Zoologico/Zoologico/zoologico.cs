using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class zoologico
    {
        public string Nombre;
        public string Direccion;
        public int Telefono;
        List<Jaula> jaula;

        public zoologico(string nombre, string direccion, int telefono, List<Jaula> jaula)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            jaula = new List<Jaula>();
        }
        
    }
}
