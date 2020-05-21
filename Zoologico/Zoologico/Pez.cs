using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Pez
    {
        public string Nombre;
        public double Longitud;

        public Pez(string nombre, double longitud)
        {
            this.Nombre = nombre;
            this.Longitud = longitud;
        }
        public override string ToString()
        {
            return "Nombre" + Nombre + "Longitud" + Longitud;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public double getLongitud()
        {
            return Longitud;
        }
        public void setLongitud(double longitud)
        {
            this.Longitud = longitud;
        }
    }
}
